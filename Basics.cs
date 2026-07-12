//Hi My name is Selase Apietu. 
//Welcome to my journey of learning C# to become a software Engineer.

//Printing output on the console

Console.WriteLine("Hello World"); //This command adds a line feed at the end of your output.

Console.Write("My name is ");
Console.Write("selase."); //This command prints out outputs on the same line.

//Data Types

//A "literal Character" is use to print a single aphanumeric character to the output

Console.WriteLine('B');// writing this "Console.WriteLine('BSE')" will produce an error
string message = 'C';
Console.WriteLine(message);

//A "literal int"


Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine("You rolled a " + roll); 