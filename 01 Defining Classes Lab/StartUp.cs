using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        //shift + alt + f - You can change these in Tools > Options > Environment -> Keyboard (either by selecting a different "keyboard mapping scheme", or binding individual keys to the commands "Edit.FormatDocument" and "Edit.FormatSelection").

        BankAccount account = new BankAccount();

        account.Deposit(44.2m);  //testing

        Console.WriteLine(account.Balance);

        account.Withdraw(12.2m); //testing

        Console.WriteLine(account.Balance);

        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "End")
        {
            //int id = int.Parse(cmdArgs[1]); massive repetition of code...
            string[] cmdArgs = command.Split();
            string cmdType = cmdArgs[0];

            switch (cmdType)
            {
                case "Create": Create(cmdArgs, accounts); break;
                case "Deposit": Deposit(cmdArgs, accounts); break;
                case "Withdraw": Withdraw(cmdArgs, accounts); break;
                case "Print": Print(cmdArgs, accounts); break;
            }
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArgs[1]);
        //Console.WriteLine(accounts.Where(x => x.Key == id).ToString());
        foreach (var kvp in accounts)
        {
            if (kvp.Key == id)
            {
                Console.WriteLine(id + " " + kvp.Value.Balance);
                break;
            }
        }
    }

    public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount account = new BankAccount();
            accounts.Add(id, account);
        }
    }

    public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArgs[1]);
        decimal deposit = decimal.Parse(cmdArgs[2]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(deposit);
        }
        else
        {
            Console.WriteLine("Such account doesn't exist!");
        }
    }

    public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArgs[1]);
        decimal deposit = decimal.Parse(cmdArgs[2]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Withdraw(deposit);
        }
        else
        {
            Console.WriteLine("Such account doesn't exist!");
        }
    }
}