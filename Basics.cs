//Hi My name is Selase Apietu. 
//Welcome to my journey of learning C# to become a software Engineer.

//Printing output on the console

Console.WriteLine("Hello World"); //This command adds a line feed at the end of your output.

Console.Write("My name is ");
Console.Write("selase."); //This command prints out outputs on the same line.

//Data Types

//A "literal Character" is use to print a single aphanumeric character to the output

Console.WriteLine('B');// writing this "Console.WriteLine('BSE')" will produce an error
char message = 'C';
Console.WriteLine(message);

//A "literal int" outputs whole numeric nubers
int wholeNumber = 21;
Console.WriteLine(wholeNumber);

//"Floating Point Literals" outputs decimal numbers
//C# supports up to three data types to represent decimals. (Float, Double, and Decimal)

//Floats supports 6-9 digits. to create a float value append the letter "f"
float myFloat = 3.1415927f;
Console.WriteLine("Float: " + myFloat);

//Double supports 15-17 digits. Double is the default for decimal numbers, so no suffix is required.
double myDouble = 3.141592653589793;
Console.WriteLine("Double: " + myDouble);

//Decimal supports 28-29 digits. Decimal values end with m.
decimal myDecimal = 3.1415926535897932384626433833m;
Console.WriteLine("Decimal: " + myDecimal);

//A "Boolean Literal" outputs a true or false statement.
bool isStudent = false;
bool isEmployed = true;

Console.WriteLine(isStudent + "\n" + isEmployed);

//Variables
