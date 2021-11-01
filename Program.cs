using System;
using System.Linq;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("How Old Are You? ");
            // double input = double.Parse(Console.ReadLine());
            // Console.WriteLine("My age is " + input);
            // Console.Write("First Write Hello" + input);
            // Console.WriteLine("First Write Hello " + input);
            // Console.Write("End of execution");

            //void slimShady()
            //{
            //    string word = "\nSlicka\n Slicka\n  Slicka Slim Shady \n";
            //    for (double i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine("\nHi, My name is. . . ");
            //    }
            //    Console.WriteLine(word);
            //}


            bool flag = true;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please choose your program:\n1) Calculate Income\n2) Student GPA Check\n3) Multiply Values\n4) Divide Two numbers\n5) Compare Two numbers\n6) Even or Odd\n7) SubMenu\n8) Exit");
                int option = int.Parse(Console.ReadLine());
                string name;
                double num1;
                double num2;

                switch (option)
                { 

                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You're running program {0}", option);
                        double hrWage;
                        double hrWeek;
                        double result;
                        Console.WriteLine("\nWhat is your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("What is your hourly rate of pay? ");
                        hrWage = double.Parse(Console.ReadLine());
                        Console.WriteLine("How many hours do you work per week? ");
                        hrWeek = double.Parse(Console.ReadLine());
                        result = (((hrWage * hrWeek) * 4) * 12);
                        Console.WriteLine(name + "'s salary is: $" + result + " dollars per year.");
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        double sGPA;
                        double pGPA = 2.50;
                        Console.WriteLine("You're running program {0}", option);
                        Console.WriteLine("What's your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("What's your current gpa? ");
                        sGPA = double.Parse(Console.ReadLine());
                        if (sGPA >= pGPA)
                        {
                            Console.WriteLine("Congratulations" + name + ", you're passing!");
                        }
                        else
                        {
                            Console.WriteLine(name + ", you're currently failing your classes, clean it up.");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        double result1;
                        Console.WriteLine("You're running program {0}", option);
                        Console.WriteLine("What's your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Let's multiply two values! Please enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("What's your second number? ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num1.Equals(0) || num2.Equals(0))
                        {
                            Console.WriteLine("If you take anything times 0, you'll get 0. Silly Goose.");
                        }
                        else
                        {
                            result1 = num1 * num2;
                            Console.WriteLine(num1 + " times " + num2 + " equals: " + result1 + "!\nThanks for playing!");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You're running program {0}", option);
                        Console.WriteLine("What's your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Lets divide two numbers. Please provide the number to be divided: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please provide the number to divide by: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2.Equals(0)) {
                            Console.WriteLine(name + ", you know you can't divide by zero. Silly Goose.");
                        }
                        else
                        {
                            result1 = num1 / num2;
                            Console.WriteLine(num1 + " divided by " + num2 + " is equal to: " + result1 + "\nThanks for playing!");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You're running program {0}", option);
                        Console.WriteLine("What's your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Lets compare two numbers. Please provide the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please provide the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {
                            Console.WriteLine("The larger of the two numbers is: " + num1 + ".\nThanks for playing, " + name + "!");
                        }
                        else if (num1 == num2)
                        {
                            Console.WriteLine("Nice try, " + name + ". Your two numbers are equal!");
                        }
                        else
                        {
                            Console.WriteLine("The larger of the two numbers is: " + num2 + ".\nThanks for playing, " + name + "!");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break; 

                    case 6: 
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You're running program {0}", option);
                        Console.WriteLine("What's your name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Lets determine if your numer is even or odd. Please provide a number: ");
                        num1 = double.Parse(Console.ReadLine());
                        if((num1 % 2 == 0) && (num1 / 2 != 0))
                        {
                            Console.WriteLine("Your number is even!\nThanks for playing, " + name + "!");
                        }
                        else if (num1.Equals(0))
                        {
                            Console.WriteLine("Nice try, " + name + ". You'll have to do better than that.");
                        }
                        else
                        {
                            Console.WriteLine("Your number is odd!\nThanks for playing, " + name + "!");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;

                    case 7:
                        bool submenu = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Choose an option:\n1) Guess the number\n2) It it prime?\n3) Go Back");
                            int option2 = int.Parse(Console.ReadLine());

                            switch (option2)
                            {

                                case 1:
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You're running the number guessing program!");
                                    Random rand = new Random();
                                    int randNumber = rand.Next(0, 100);
                                    int guess = 0;
                                    int i = 3;
                                    //Console.WriteLine(randNumber);
                                    while (i > 0)
                                    {
                                        Console.WriteLine($"You have {i} guesses remaining.\nPlease guess a number between 1 and 100: ", i);
                                        guess = int.Parse(Console.ReadLine());
                                        if (guess == randNumber)
                                        {
                                            Console.WriteLine("You guessed the correct number! Great job!");
                                            Console.WriteLine("Press any key to continue.");
                                            Console.ReadKey();
                                            break;
                                        }
                                        else if (guess > randNumber)
                                        {
                                            Console.WriteLine("Your guess was too high!");
                                        }
                                        else if (guess < randNumber)
                                        {
                                            Console.WriteLine("Your guess was too low!");
                                        }
                                        i--;
                                    }
                                    if (i == 0)
                                    {
                                        Console.WriteLine("You have lost the game. Sucks to suck, I'd imagine.");
                                        Console.WriteLine("Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;


                                case 2:
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Please enter a number: ");
                                    int prime = int.Parse(Console.ReadLine());
                                    bool isPrime = true;
                                    for (int n = 2; n < prime / 2; n++)
                                    {
                                        if (prime % n == 0)
                                        {
                                            isPrime = false;
                                            break;
                                        }
                                    }
                                    if (isPrime)
                                    {
                                        Console.WriteLine("Your number is Prime!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your number is not Prime!");
                                    }
                                    break;


                                case 3:
                                    Console.WriteLine("You've chosen to exit, take it easy!");
                                    submenu = false;
                                    Console.WriteLine("\nPress any key to Exit");
                                    Console.ReadKey();
                                    break;

                            }
                        } while (submenu == true);
                        break;


                        // Is it a prime number? (say a number, computer outputs if prime number)
                        // one last exercise after this

                    case 8:
                         Console.WriteLine("You've chosen to exit, take it easy!");
                         flag = false;
                         Console.WriteLine("\nPress any key to Exit");
                         Console.ReadKey();
                         break;

                    default:
                        Console.WriteLine("The program you've selected doesn't exist.");
                        break;
                }

            } while (flag);
        }
    }
}