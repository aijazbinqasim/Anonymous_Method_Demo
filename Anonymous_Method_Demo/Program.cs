namespace Anonymous_Method_Demo
{
    public delegate void Print1();
    public delegate void Print2(string firstName);
    public delegate void Addition(int val1);

    internal class Program
    {
        static void Main(string[] args)
        {

            Print1 p1 = delegate ()
            {
                Console.WriteLine("Inside p1 Anynomous method");
            };

            p1();


            var firstName = "Aijaz";
            Print2 p2 = delegate (string surname)
            {
                Console.WriteLine($"Full Name: {firstName} {surname}");
            };

            p2("Ali");

           // HelperMethod(delegate (int val1) { Console.WriteLine($"Addition: {val1 + 100}"); });
            HelperMethod(val1 =>  Console.WriteLine($"Addition: {val1 + 100}"));

        }


        public static void HelperMethod(Addition addition)
        {
            addition(100);
        }
    }
}
