namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DescendingOrder(10);
            static void DescendingOrder(int n) 
            {
                if (n == 0)
                {
                    return;
                }
                else 
                {
                    Console.Write(n + " ");
                    DescendingOrder(n - 1);
                }

            }
        }
    }
}
