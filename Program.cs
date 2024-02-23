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
        }
    }
}