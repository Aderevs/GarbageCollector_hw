namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of big object");
            int size = int.Parse(Console.ReadLine());
            using (ClassWithBigObjects bigObject = new ClassWithBigObjects(size))
            {
                bigObject.PrintArr();
            }
        }
    }
}
