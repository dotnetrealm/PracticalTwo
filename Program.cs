namespace PracticalTwo
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount account = new(1231231231, "Bhavin");
            account.BankName = "Bank Of Baroda";
            account.PrintInfo();
            Console.ReadLine();
        }
    }

    internal class CustomerAccount
    {
        public string BankName = default!;
        private readonly long _customerAccountNo;
        private readonly String _customerName;

        internal CustomerAccount(long accountNo, String customerName)
        {
            _customerName = customerName;
            _customerAccountNo = accountNo;
        }

        /// <summary>
        /// Prints customer account information
        /// </summary>
        internal void PrintInfo()
        {
            Console.WriteLine("\n==============BANK DETAIL==============");
            Console.WriteLine($"Bank name: {BankName}");
            Console.WriteLine($"Account holder name: {_customerName}");
            Console.WriteLine($"Account number: {_customerAccountNo}");
            Console.WriteLine("==============BANK DETAIL==============\n");
        }

        /// <summary>
        /// Prints customer information & hide sensitive information
        /// </summary>
        internal void PrintMaskedInfo()
        {
            Console.WriteLine("\n==============BANK DETAIL==============");
            Console.WriteLine($"Bank name: {BankName}");
            Console.WriteLine($"Account holder name: {_customerName}");
            Console.WriteLine($"Account number: {GetAccountNumber}");
            Console.WriteLine("==============BANK DETAIL==============\n");
        }

        public string GetAccountNumber
        {
            get
            {
                return "***-***-" + _customerAccountNo.ToString().Substring(6, 4);
            }
        }
    }
}