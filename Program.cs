using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int continuar = 1;
        while (continuar == 1)
        {
           
            Console.Write("\nDigite a primeira palavra: ");
            string Palavra1 = Console.ReadLine();

            Console.Write("\nDigite a segunda palavra: ");
            string Palavra2 = Console.ReadLine();

            if (Anagrama(Palavra1, Palavra2))
                Console.Write("\nAnagrama detectado!\n");

            else
                Console.Write("\nNão foi detectado um anagrama!\n");

            Console.ReadKey();

            Console.WriteLine("\nDeseja verificar a tabuada de algum outro número? Digite 1 para SIM ou 2 para NAO");
            continuar = int.Parse(Console.ReadLine());
        }

        static bool Anagrama(string str1, string str2)
        {
            try
            {
                if (!Regex.IsMatch(str1, @"^[a-zA-Z]+$"))
                {
                    Exception ex = new Exception();
                    throw new ArgumentOutOfRangeException("\nPor favor insira somente letras na palavra 1", ex);
                }
                else if (!Regex.IsMatch(str2, @"^[a-zA-Z]+$"))
                {
                    Exception ex = new Exception();
                    throw new ArgumentOutOfRangeException("\nPor favor insira somente letras na palavra 2", ex);
                }

                return SorteandoAsLetras(str1.ToLower()) == SorteandoAsLetras(str2.ToLower());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static string SorteandoAsLetras(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}