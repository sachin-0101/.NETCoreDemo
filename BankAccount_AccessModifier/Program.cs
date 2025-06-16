using BankAccount_AccessModifier;

//Author: Sachin K
class Program
{
    static void Main()
    {
        // Create a new bank account object with account number, owner name, and initial balance
        BankAccount account = new BankAccount("567142545", "Sachin K", 1000); 
        account.PrintAccountSummary(); 

        Console.Write("Enter amount to Deposit :");
        int inputDeposit = Convert.ToInt32(Console.ReadLine());
        account.Deposit(inputDeposit);
        Console.WriteLine($"Successfully deposited {inputDeposit} to your account");      
        account.PrintAccountSummary();  

        Console.Write("Enter amount to Withdraw :");
        int inputWithdraw = Convert.ToInt32(Console.ReadLine());        
        bool success = account.Withdraw(inputWithdraw);
        Console.WriteLine(success ? $"Successfully withdraw {inputWithdraw} from your account." : " Withdrawal failed due to insufficient funds");       
        account.PrintAccountSummary();

    }
}
