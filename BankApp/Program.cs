using System;

namespace Bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************"); 
            Console.WriteLine("Welcome to my Bank");
            while (true)
            {
                Console.WriteLine("0:Exit");
            Console.WriteLine("1:Create an Account");
            Console.WriteLine("2:Deposit");
            Console.WriteLine("3:Withdraw");
            Console.WriteLine("4:View all accounts");
            Console.WriteLine("4:View all transactions");
            Console.Write("Select an option:");
            
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bank");
                        return;
                    case "1":
                        Console.Write("Account Name:");
                        var accountName = Console.ReadLine();
                        Console.Write("Email Address:");
                        var emailAddress = Console.ReadLine();
                        Console.WriteLine("Select an account Type");
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccounts));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}.{accountTypes[i]}");

                        };
                        //var accountType = (TypeOfAccounts)Enum.Parse(typeof(TypeOfAccounts),Console.ReadLine());
                        var accountType = Enum.Parse<TypeOfAccounts>(Console.ReadLine());
                        Console.Write("Amount to Deposit:");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        var account = BankApp.Bank.CreateAccount(accountName, emailAddress, accountType, amount);
                        Console.WriteLine($"ANumber:{account.AccountNumber}," + $"AName:{account.AccountName}," +
                                            $"ABalance:{account.Balance}", $"emailAddress:{ account.EmailAddress}",
                                             $"AType:{account.AccountType}");
                        break;
                    case "2":

                    case "3":
                    case "4":
                    case "5":
                    default:
                        Console.WriteLine("Invalid Option!Try again!");
                        break;

                }
            }



            /*var myAccount = BankApp.Bank.CreateAccount("My Checking","test@test.com",TypeOfAccounts.Savings,100);
            //myAccount.AccountNumber = 123456;
            //myAccount.AccountName = "My Checking";
            //myAccount.Deposit(1001);
            Console.WriteLine($"AN:{myAccount.AccountNumber} ,AN:{myAccount.AccountName} ,AB:{myAccount.Balance}");*/

            /*var myAccount2 = new Account();
            //myAccount2.AccountNumber = 34567;
            myAccount2.AccountName = "My Checking2";
            Console.WriteLine($"AN:{myAccount2.AccountNumber} ,AN:{myAccount2.AccountName} ,AB:{myAccount2.Balance}");*/
        }
    }
}
