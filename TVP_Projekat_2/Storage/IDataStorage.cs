using Restoran.Entiteti;
using System.Collections.Generic;

namespace Restoran.Storage
{
    public interface IDataStorage
    {
        IList<Jelo> GetJela();

        IList<Prilog> GetPrilozi();

        IList<Prilog> GetPrilogZaJelo(int id);

        int DodajPrilog(string naziv, int cena);

        int DodajJelo(string naziv, int cena, List<Prilog> prilozi);

        void Close();
    }
}
