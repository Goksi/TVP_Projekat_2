namespace Restoran.Entiteti
{
    public class StavkaRacuna
    {
        private readonly Jelo jelo;
        private readonly Prilog prilog;

        public StavkaRacuna(Jelo jelo, Prilog prilog)
        {
            this.jelo = jelo;
            this.prilog = prilog;
        }

        public int UkupnaCena => CenaJelo + CenaPrilog;

        public int CenaJelo => jelo.Cena;

        public int CenaPrilog => prilog != null ? prilog.Cena : 0;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return obj is StavkaRacuna druga &&
                   jelo == druga.jelo &&
                   prilog == druga.prilog;
        }

        public override int GetHashCode()
        {
            int hashCode = -1228211071;
            hashCode = hashCode * -1521134295 + jelo.GetHashCode();
            if (prilog != null)
            {
                hashCode = hashCode * -1521134295 + prilog.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(StavkaRacuna left, StavkaRacuna right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(StavkaRacuna left, StavkaRacuna right)
        {
            return !(left == right);
        }
    }
}
