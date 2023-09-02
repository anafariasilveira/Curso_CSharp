namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiaDosNamorados dn = new("Hugo");
            dn.ShowMessage();

            Natal nt = new("Ana");
            nt.ShowMessage();

            Aniversario hb = new("Sophia");
            hb.ShowMessage();

        }
    }
}