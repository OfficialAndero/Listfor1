namespace Listfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primeNumber = new List<int>();
            primeNumber.Add(2);
            primeNumber.Add(3);
            primeNumber.Add(5);
            primeNumber.Add(7);

            Console.WriteLine("no of elements:" + primeNumber.Count);
             var cities = new List<string>();
            cities.Add("Rome");
            cities.Add("Moscow");
            cities.Add("Paris");
            cities.Add("Singapore");
            cities.Add(null);

            Console.WriteLine("No of elements: " + cities.Count);
        }
    }
}
