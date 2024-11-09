namespace _06.MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] accountData = Console.ReadLine().Split(',');
            var accounts = new Dictionary<int, double>();
            foreach (var account in accountData)
            {
                var accountInfo = account.Split('-');
                int accountNumber = int.Parse(accountInfo[0]);
                double balance = double.Parse(accountInfo[1]);
                accounts[accountNumber] = balance;
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] commandParts = command.Split();
                try
                {
                    if (commandParts[0] == "Deposit")
                    {
                        int accountNumber = int.Parse(commandParts[1]);
                        double sum = double.Parse(commandParts[2]);
                        if (accounts.ContainsKey(accountNumber))
                        {
                            accounts[accountNumber] += sum;
                            Console.WriteLine($"Account {accountNumber} has new balance: {accounts[accountNumber]:F2}");
                        }
                        else
                        {
                            throw new ArgumentException("Invalid account!");
                        }
                    }
                    else
                    if (commandParts[0] == "Withdraw")
                    {
                        int accountNumber = int.Parse(commandParts[1]);
                        double sum = double.Parse(commandParts[2]);
                        if (accounts.ContainsKey(accountNumber))
                        {
                            if (accounts[accountNumber] >= sum)
                            {
                                accounts[accountNumber] -= sum;
                                Console.WriteLine($"Account {accountNumber} has new balance: {accounts[accountNumber]:F2}");
                            }
                            else
                            {
                                throw new InvalidOperationException("Insufficient balance!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Invalid account!");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid command!");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid command!");
                }
                Console.WriteLine("Enter another command");
            }
        }
    }
}