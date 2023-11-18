using Bank.ConsoleApp.Models;
using Bank.ConsoleApp.Utilites.Exceptions;

namespace Bank.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BANK bank = new BANK();
            string item = "";
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("Welcome!");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Invest money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. List of all accounts");
                Console.WriteLine("5. Money transfers between accounts");
                Console.WriteLine("0. Exit");
                item = Console.ReadLine();
                switch (item)
                {
                    case "1":
                        Console.Clear();
                        Account account = new Account();
                        bank.CreateAccount(account);
                        break;
                    case "2":
                        Console.Clear();
                        string id = "";
                        string amount = "";
                        try
                        {
                            bank.CheckAccauntIsNull();
                            bank.DepositMoney(bank.CheeckId(id), Cheeckamount(amount));

                        }
                        catch(MyNullAbleException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(AccountNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(InvalidAmountException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }

                        break;
                    case "3":
                        Console.Clear();
                        string id2 = "";
                        string amount2= "";
                        try
                        {
                            bank.CheckAccauntIsNull();
                            bank.WithdrawMoney(bank.CheeckId(id2), Cheeckamount(amount2));

                        }
                        catch(MyNullAbleException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(InvalidAmountException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(AccountNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (InsufficientFundsException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }
                        break;
                    case "4":
                        Console.Clear();
                        try
                        {
                            bank.CheckAccauntIsNull();
                            bank.GetAllAccounts();

                        }
                        catch(MyNullAbleException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        Console.Clear();
                        string fromid = "";
                        string toid = "";
                        string amount3 = "";
                        try
                        {
                            bank.CheckAccauntForTransfer();
                            Console.WriteLine("Payer Account");
                            int fromid2 = bank.CheeckId(fromid);
                            Console.WriteLine("Money receiving account");
                            int toid2= bank.CheeckId(toid);
                            bank.TransferMoney(fromid2, toid2, Cheeckamount(amount3));

                        }
                        catch(MyNullAbleException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (AccountNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        catch(InsufficientFundsException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(InvalidAmountException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("bele secim yoxdur");
                        break;
                }
            } while (item != "0");


        }
        //public static int CheeckId(string str) 
        //{

        //    int id;
        //    Console.WriteLine("Please enter your id");
            
        //    bool result = false;
        //    do
        //    {
        //        str = Console.ReadLine();
        //        result = int.TryParse(str, out id);
        //        if (!result)
        //        {
        //            throw new InvalidAmountException("This value is not true");
        //        }
        //    } while (!result);
        //    return id;
        //}
        public static decimal Cheeckamount(string str)
        {
            decimal amount;
            bool result = false;
            Console.WriteLine("please enter amount");
            do
            {
                str = Console.ReadLine();
                result = decimal.TryParse(str, out amount);
                if (!result)
                {
                    throw new InvalidAmountException("This value is not true");
                }
            } while (!result);
            if (amount < 0)
            {
                throw new InvalidAmountException("This value is not true");
            }
            
            return amount;
        }
    }
}