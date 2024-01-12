namespace Grupp_3_CI_CD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Opersion op = new Opersion();
            // rätta person nummert 
            int personnummer = op.personmmer("sdsd");
            Console.WriteLine(personnummer);
        }
    }
}