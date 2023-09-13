namespace StaticConstructor_Partiall
{

    class Counter
    {
        public Counter() { }

        public Counter(int min=100, int max = 0)
        {
            Min = min;
            Max = max;
            Count = Min;
        }

        public void Increment()
        {
            Count++;
            if (Count > Max) Count = Min;
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public int Count { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(100, "IBAZA1234567834");
            Console.WriteLine(account.AccountSwift);    
            account.Start();

            account.ShowAccountCall();
            account.UpdateAccountCall();
        }
    }
}