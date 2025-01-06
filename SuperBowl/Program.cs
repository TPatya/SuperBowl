namespace SuperBowl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beolvasás
            List<Donto> Dontok = new();
            foreach (var sor in File.ReadAllLines("SuperBowl.txt").Skip(1)) 
            {
                Dontok.Add(new Donto(sor));
            }
            //4
            Console.WriteLine($"A döntők száma: {Dontok.Count}");

            //5
            int pontkülönbség = 0;
            foreach (var d in Dontok)
            {
                string[] e = d.Eredmeny.Split('-');
                pontkülönbség += Math.Abs(int.Parse(e[0]) - int.Parse(e[1])); 
            }
            double atlag = (double)pontkülönbség / Dontok.Count();
            Console.WriteLine($"A pontkülönbség ennyi volt: {atlag:0.0}");
        }
    }
}
