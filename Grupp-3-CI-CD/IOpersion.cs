namespace Grupp_3_CI_CD
{
    public interface IOpersion
    {
        public long personmmerToInt(string personnummer);
        public bool IsValidPersonnummer(string personnummer);
        public string Gender(string personnummer);
    }
}