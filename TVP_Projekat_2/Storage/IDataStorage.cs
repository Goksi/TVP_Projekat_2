using Restoran.Entiteti;
using System;
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

        int DodajRacun(Racun racun);

        IDictionary<StavkaRacuna, int> GetStavkeZaRacun(int id);

        IList<Racun> GetRacuni(DateTime? odDatum = null, DateTime? doDatum = null);

        Jelo GetTopJelo();

        (int, int) GetStatistike(int id);

        void Close();
    }
}
