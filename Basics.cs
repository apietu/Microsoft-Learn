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
//A variable is a container for storing a type of value. 
//To create a new variable, you must first declare the data type of the variable, and then give it a name.
string firstName;
firstName ="selase";
Console.WriteLine("My name is " + firstName);
//The above example is what we call "Explicitly typed variables"
//Explicitly typed variables are variables where you write out the actual data type when declaring them, instead of letting the compiler infer it
//eg; char userOption = "A"; int gameScore = 21; decimal particlesPerMillion = 21.05; bool processedCustomer = true;

//In C#, an implicitly typed variable is declared using the var keyword instead of writing out the actual type. 
//The compiler figures out ("infers") the type automatically based on the value you assign at declaration.
var myAge = 25;              // compiler infers int
var herName = "Alice";        // compiler infers string
var costPrice = 19.99;         // compiler infers double
var isActive = true;       // compiler infers bool

//Character escape sequence.

//An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string.
//The escape character sequence begins with a backslash \ followed by the character you're escaping. 
//"\n" will add a new line while "\t" will add a new tab
Console.WriteLine("Hello \nWorld! \t My name is selase");
//If you need to use the backslash for other purposes, like to display a file path Eg Console.WriteLine("c:\source\repos"); use "\\".
//This is because C# reserves the backslash for escape sequences.
Console.WriteLine("c:\\users\\selase\\Documents\\Workspace\\C# Projects\\Microsoft-Learn");

//Verbatim string literal
//A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
//To create a verbatim string, use the @ directive before the literal string.
Console.WriteLine(@"   c:\users\selase\Documents\Workspace\C# Projects\Microsoft-Learn    
        (this is where your project is.)");

//You can also add encoded characters in literal strings using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

//String Concatenation
//String concatenation is "programmer speak" for simply combining two or more string values into a new string value.
//To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.
string firstNname = "Bob";
string messsage = "Hello " + firstNname;
Console.WriteLine(messsage);

//String interpolation
//String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions.
//An interpolation expression is indicated by an opening and closing curly brace symbol { }.
//You can put any C# expression that returns a value inside the braces. The literal string becomes a template when it's prefixed by the $ character.
int version = 11;
string updateText = "Update to Windows";
string messagee = $"{updateText} {version}";
Console.WriteLine(messagee);


//Basic operations on numbers in C#

//+ is the addition operator
//- is the subtraction operator
//* is the multiplication operator
//"/" is the division operator
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);