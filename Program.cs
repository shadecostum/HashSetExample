namespace HashSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> list = new HashSet<int>
            {
                1,
                2,
                3,1
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            HashSet<Coustumer> set = new HashSet<Coustumer>
           {
               new Coustumer(1,"Akash"),
               new Coustumer(2,"allen"),
               new Coustumer(3,"babu"),
               new Coustumer(2,"king")
           };

            Console.WriteLine("Count:"+set.Count);
            foreach (var item in set)
            {
                Console.WriteLine(item.Id+","+item.Name);
            }

            Coustumer coustumer = new Coustumer(4,"aas");
            Console.WriteLine(coustumer);

            foreach (var item in set)
            {
                Console.WriteLine(item.Id+","+item.Name);
            }

        }
    }
}