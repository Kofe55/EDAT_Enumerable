internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enumerables");
        Console.WriteLine("Hello, World!");

        #region Lista

        

        var lista = new List<String>
        {
            "PABLO",
            "ANGEL",
            "URIEL",
            "MAURICIO",
            "GUERRERO",
            "Teodoro",
            "Juan"
        };


        lista.Add("sonia");




        //foreach (var nombre in lista)
        //{

        //   Console.WriteLine(nombre);

        // }

        lista.Order();

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);

        }

        Console.WriteLine(lista);


#endregion

        Console.ReadKey();


    }
}