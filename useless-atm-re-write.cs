// Remember that this ATM was taken from https://www.c-sharpcorner.com/blogs/atm-transactions-in-c-sharp, and I don't really take any credit for making this.
// I used some references, only a little. Most of the code was written from my own skill or memory.
// This code is free, but make sure to credit the original tutorial.
// I'm uploading this to github so that I dont lose it, but also to help some of my friends learn.

// Customization

Console.Title = "Useless ATM re-write";

// Variables

int PIN = 1924;
int pinReader;
int balance = 500;
int choice;

// If they enter the pin correctly, it will execute the main code
// rememember that \n means that the it will go to a new line, without making a new print statement
Console.WriteLine("Welcome the to Useless ATM re-write!\nPlease enter your pin:");
pinReader = Convert.ToInt32(Console.ReadLine());
// It will compare the pin written by the user to the actual correct pin.
if(pinReader == PIN){
    // Console.ForegroundColor changes the color of the text. It's optional, but I do it because it just looks good.
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("PIN Correct!\nYour current balance is $500.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please enter the number of your choice.\n1. Deposit\n2. Withdrawl\n3. Change Pin\n4. Check Current Balance\n");
    choice = Convert.ToInt32(Console.ReadLine());
    // Depending on the number they chose, it will execute the command. For an example:
    // If they chose 1, which is Deposit, it will give them the code for deposting money.
    // Im using switch statements instead of a bunch of if statements to clean up my code
    switch(choice){
        case 1:
            Console.WriteLine("Please enter the amount of money you would like to deposit:");
            int dpAm = int.Parse(Console.ReadLine());
            // To calculate the total, you add the balance with the amount of money the user wants to deposit
            int dpTotal = balance + dpAm;
            Console.ForegroundColor = ConsoleColor.Green;
            // Use "thingy" + variable + "thingy" so that you can print stuff, and add variables.
            Console.WriteLine("You have successfully deposited " + dpAm + ", and your current balance is now $" + dpTotal + ".");
            Console.ForegroundColor = ConsoleColor.White;
        break;
        case 2:
            Console.WriteLine("Please enter the amount of money you would like to withdrawl:");
            int wdAm = Convert.ToInt32(Console.ReadLine());
            // Basically the same thing as deposit. You subtract the balance to the amount of money the user wants to take out.
            int wdTotal = balance - wdAm;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have successfully withdrawled $" + wdAm + ", and your current balance is now" + wdTotal + ".");
            Console.ForegroundColor =ConsoleColor.White;
        break;
        case 3:
            Console.WriteLine("Please enter your new PIN:");
            int newPin = Convert.ToInt32(Console.ReadLine());
            // This section is kinda useless. All it does it change your pin, but after that, it does nothing.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your new pin is now: " + newPin);
            Console.ForegroundColor = ConsoleColor.White;
        break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Green;
            // Simpily prints your balance.
            Console.WriteLine("Your current balance is: $" + balance);
            Console.ForegroundColor = ConsoleColor.White;
        break;
        default:
        // if they don't enter a correct choice, they will get this.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect choice, please try again.");
        break;
    }
}
else
{
    //If they dont enter the correct pin, the code will stop.
    Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Wrong pin. Please try again.");
}
// credits, remember that the one who should be really taking credits is the tutoiral
// https://www.c-sharpcorner.com/blogs/atm-transactions-in-c-sharp
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("(sorta) made by EpicGamer45#9027\n------------------------------------------\nI copied this ATM from some tutorial a while back\nand decided to re-write it without looking at references too much.\n(i still looked at some references lmao)\nOriginal tutorial: https://www.c-sharpcorner.com/blogs/atm-transactions-in-c-sharp");
// I forgot to do this so much, if you don't put this here, it will automatically close once the program has done all commmands.
Console.ReadKey();
