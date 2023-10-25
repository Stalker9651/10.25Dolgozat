namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> lista = new List<Bolygo>();


            using var sr = new StreamReader(@"..\..\..\src\solsys.txt");
            while (!sr.EndOfStream) { 
                lista.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine("3. feladat:");
            Console.WriteLine($"\t3.1{lista.Count} bolygó van a naprendszerben");
            Console.WriteLine($"\t3.2 a naprendszerben egy bolygónak átlagosan {lista.Average(v => v.Holdjai)} holdja van");
            Console.WriteLine($"\t3.3 a legnagyobb térfogatú bolygó a {lista.MaxBy(v => v.Terfogataranya).Nev}");
            Console.Write($"\t3.4 írd be a keresett bolygó nevét: ");
            string input = Console.ReadLine();
            if (lista.Contains(lista.Find(v => v.Nev.ToLower() == input.ToLower())))
            {
                Console.WriteLine(":3");
            }
            else
            {
                Console.WriteLine("\t\tsajnos nincs ilyen nevű bolygó a naprendszerben.");
            }
            Console.Write($"\t3.5 írj be egy egész számot:");
            int input2 = int.Parse(Console.ReadLine());
            var f35 = lista.Where(v => v.Holdjai > input2);
            Console.WriteLine($"A következő bolygóknak van {input2}-nál/nél több holdja:  ");
            foreach (var item in f35)
            {
                Console.Write($"'{item.Nev}' ");
            }
        }
    }
}