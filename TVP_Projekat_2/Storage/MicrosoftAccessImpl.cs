using Restoran.Entiteti;
using System.Collections.Generic;

namespace Restoran.Storage
{
    internal class MicrosoftAccessImpl : IDataStorage
    {
        private ConnectionWrapper connection;

        public MicrosoftAccessImpl()
        {
            /*DATABASE STRING*/
            connection = new ConnectionWrapper(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Restoran.accdb");
        }
        public IList<Jelo> GetJela()
        {
            return connection.UseQuery("select * from Jelo", (reader) =>
            {
                IList<Jelo> jela = new List<Jelo>();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_jelo"].ToString());
                    string naziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    Jelo jelo = new Jelo(id, naziv, cena);
                    jelo.MoguciPrilozi = GetPrilogZaJelo(id); //TODO: ne svidja mi se, moguca optimizacija ?
                    jela.Add(jelo);
                }
                return jela;
            });
        }
        public IList<Prilog> GetPrilogZaJelo(int id)
        {
            return connection.UseQuery(
                "select * from Prilog inner join Pripadnost on Prilog.id_prilog = Pripadnost.id_prilog " +
                "where Pripadnost.id_jelo = @0",
                (reader) =>
            {
                IList<Prilog> prilozi = new List<Prilog>();
                while (reader.Read())
                {
                    int prilogId = int.Parse(reader["Prilog.id_prilog"].ToString());
                    string prilogNaziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    prilozi.Add(new Prilog(prilogId, prilogNaziv, cena));
                }
                return prilozi;
            }, id);
        }

        public IList<Prilog> GetPrilozi()
        {
            return connection.UseQuery("select * from Prilog", (reader) =>
            {
                IList<Prilog> prilozi = new List<Prilog>();
                while (reader.Read())
                {
                    int prilogId = int.Parse(reader["id_prilog"].ToString());
                    string prilogNaziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    prilozi.Add(new Prilog(prilogId, prilogNaziv, cena));
                }
                return prilozi;
            });
        }

        public int DodajPrilog(string naziv, int cena)
        {
            return connection.UseVoidQuery("insert into Prilog(naziv, cena) values (@0, @1)", naziv, cena);
        }

        public int DodajJelo(string naziv, int cena, List<Prilog> prilozi)
        {
            int jeloId = connection.UseVoidQuery("insert into Jelo(naziv, cena) values (@0, @1)", naziv, cena);
            foreach (Prilog prilog in prilozi)
            {
                connection.UseVoidQuery("insert into Pripadnost(id_jelo, id_prilog) values (@0, @1)", jeloId, prilog.Id);
            }
            return jeloId;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
