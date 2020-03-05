using System;

namespace cashmashine
{
    class Program
    {
        // void withdraw(int bankBalance, int wihdrawlAmount)
        // {
        //     Console.WriteLine(bankBalance -= wihdrawlAmount);
        //     Console.WriteLine("My new balance is: {0}", bankBalance);
        // }

        // void checkPin(string userInput, string pinNumber) 
        // {
        //     // if userInput is equal to the pinnumber ... do something
        //     // if it isn't ... do something
        //     if(userInput == pinNumber)
        //     {
        //         Console.WriteLine("Correct");
        //     } else 
        //     {
        //         Console.WriteLine("Try agan! Wrong Pin!");
        //     }
        // }

         void checkPin()
        {
        // dont use it too much, it can get messi
        START:
            string pinNumber = "0000";
            string userInput;
            Console.WriteLine("Please enter your PIN: ");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            if (pinNumber == userInput)
            {
                Console.WriteLine("Whoa, you are correct");
                Console.WriteLine("What next? 1.Take cash? 2.Change pin? 3.Add cash? 4.Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    takeCash();
                }
                else if (userInput == "2")
                {
                    changePIN();
                }
                else if (userInput == "3")
                {
                    addCash();
                }
                else if (userInput == "4") 
                {
                    exit();
                }
            }
            else
            {
                // Console.WriteLine("NO!");
                goto START;
            }
        }

        void takeCash()
        {
            int balance = 500;
            int userInput = 0;
            string userString;
            Console.WriteLine("How much would you withdraw?");
            userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput > balance)
            {
                Console.WriteLine("Go make some more money!");
                exit();
            }
            else
            {
                int newBalance = balance - userInput;
                Console.WriteLine("Your new balance is {0}", newBalance);
                Console.WriteLine("What next? 1.Exit? 2.Change pin? 3.Add cash");
                userString = Console.ReadLine();

                if (userString == "1")
                {
                    exit();
                }
                else if (userString == "2")
                {
                    changePIN();
                }
                else if (userString == "3")
                {
                    addCash();
                }
                else
                {
                    takeCash();
                }
            }
        }

        void changePIN()
        {
            string userInput;
            string userPIN = "0000";
            Console.WriteLine("Would you like to change your pin? 1.Yes or 2.No");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("Please re-enter your CURRENT PIN: ");
                userInput = Console.ReadLine();
                if (userInput == userPIN)
                {
                    newPin();
                }
                else 
                {
                    Console.WriteLine("Something went wrong!");
                    changePIN();
                }
            }
            else
            {
                Console.WriteLine("Something went wrong! Try agan!");
                checkPin();
            }

        }

        void newPin()
        {
            string userInput;
            string userPIN = "0000";

            Console.WriteLine("Please enter your NEW PIN: ");
            
                    userInput = Console.ReadLine();
                    if(userInput == userPIN) 
                    {
                        Console.WriteLine("You can't use the same PIN");
                        newPin();
                    }
                    else
                    {
                    userPIN = userInput;

                    Console.WriteLine("Your NEW PIN is: ${0}", userPIN);
                    Console.WriteLine("What next? 1.Exit? 2.Take cash? 3.Add cash?");

                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        exit();
                    }
                    else if (userInput == "2")
                    {
                        takeCash();
                    }
                    else if (userInput == "3")
                    {
                        addCash();
                    }
                    else 
                    {
                        Console.WriteLine("Someting went wrong!");
                        changePIN();
                    }
                    }

        }

        void addCash()
        {
            int balance = 500;
            int userInput = 0;
            string userString;

            Console.WriteLine("How much would you add?");

            userInput = Convert.ToInt32(Console.ReadLine());
            int newBalance = balance + userInput;

            Console.WriteLine("Your new balance is {0}", newBalance);
            Console.WriteLine("What next? 1.Exit? 2.Take cash? 3.Change pin? ");

            userString = Console.ReadLine();

            if (userString == "1")
            {
                exit();
            }
            else if (userString == "2")
            {
                takeCash();
            }
            else if (userString == "3")
            {
                changePIN();
            }
            else
            {
                checkPin();
            }
        }

        void exit()
        {
            string userInput;
            Console.WriteLine("Exit? 1.Yes or 2.No");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("Done! Bye!");
            }
            else
            {
                checkPin();
            }
        }

        static void Main(string[] args)
        {
            Program cashmashine = new Program();
            // cashmashine.withdraw(500, 30);

            // //taking useriput
            // string pinNumber = "0000";
            // string userInput;
            // Console.WriteLine("Please enter your input: ");
            // userInput = Console.ReadLine();
            // Console.WriteLine(userInput);
            cashmashine.checkPin();
            // cashmashine.takeCash();
            // cashmashine.changePIN();
            // cashmashine.exit();

        }
    }
}
