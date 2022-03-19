// Customization

Console.Title = "Useless ATM re-write";

// Variables

int PIN = 1924;
int pinReader;
int balance = 500;
int choice;

Console.WriteLine("Welcome the to Useless ATM re-write!\nPlease enter your pin:");
pinReader = Convert.ToInt32(Console.ReadLine());

if(pinReader == PIN){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("PIN Correct!\nYour current balance is $500.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please enter the number of your choice.\n1. Deposit\n2. Withdrawl\n3. Change Pin\n4. Check Current Balance\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1:
            Console.WriteLine("Please enter the amount of money you would like to deposit:");
            int dpAm = int.Parse(Console.ReadLine());

            int dpTotal = balance + dpAm;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have successfully deposited " + dpAm + ", and your current balance is now $" + dpTotal + ".");
            Console.ForegroundColor = ConsoleColor.White;
        break;
        case 2:
            Console.WriteLine("Please enter the amount of money you would like to withdrawl:");
            int wdAm = Convert.ToInt32(Console.ReadLine());

            int wdTotal = balance - wdAm;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have successfully withdrawled $" + wdAm + ", and your current balance is now" + wdTotal + ".");
            Console.ForegroundColor =ConsoleColor.White;
        break;
        case 3:
            Console.WriteLine("Please enter your new PIN:");
            int newPin = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your new pin is now: " + newPin);
            Console.ForegroundColor = ConsoleColor.White;
        break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your current balance is: $" + balance);
            Console.ForegroundColor = ConsoleColor.White;
        break;
        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect choice, please try again.");
        break;
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Wrong pin. Please try again.");
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("(sorta) made by EpicGamer45#9027\n------------------------------------------\nI copied this ATM from some tutorial a while back\nand decided to re-write it without looking at references too much.\n(i still looked at some references lmao)");

Console.ReadKey();