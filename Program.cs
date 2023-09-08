//// integer
//int number1 = 10, number2 = 20;

//// double
//double number3 = 12, number4 = 13;

//// boolean
//bool isnum = true, isnum1 = false;

//// String
//string str1 = "hello", str2 = "bye bye";

//// Print all the variables
//Console.WriteLine($"The datatype of number1 is {number1.GetType()}, and the value it contains is {number1} ");
//Console.WriteLine($"The datatype of number2 is {number2.GetType()}, and the value it contains is {number2} ");
//Console.WriteLine($"The datatype of number3 is {number3.GetType()}, and the value it contains is {number3} ");
//Console.WriteLine($"The datatype of number4 is {number4.GetType()}, and the value it contains is {number4} ");

//Console.WriteLine($"The datatype of isnum is {isnum.GetType()}, and the value it contains is {isnum} ");
//Console.WriteLine($"The datatype of isnum1 is {isnum1.GetType()}, and the value it contains is {isnum1} ");

//Console.WriteLine($"The datatype of str1 is {str1.GetType()}, and the value it contains : {str1} ");
//Console.WriteLine($"The datatype of str2 is {str2.GetType()}, and the value it contains : {str2} ");


//// Console Input
//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your age");
//string age = Console.ReadLine();
////int convertedAge = Convert.ToInt32( age );
////int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"Hello {name}, you are {age} yrs. Old. ");


//// Conversion or in techincal terms it is as Type Casting.
//// implicit and explicit

//// declare an integer
//int toConvert = 99;


//double convertToDouble = toConvert; // Implicit TypeCasting
//double convertToDouble2 = (double) toConvert; // Explicit TypeCasting


//Console.WriteLine($"convertToDouble Datatype: {convertToDouble.GetType()}");
//Console.WriteLine($"convertToDouble2 Datatype: {convertToDouble2.GetType()}");

//// To convert to a string
//String str = toConvert.ToString();
//Console.WriteLine("STR Datatype "+str.GetType());

//string convertDouble1 = convertToDouble.ToString();
//Console.WriteLine("ConvertDouble1 Datatype "+convertDouble1.GetType());

//double numberToInt = 123.33;
//Console.WriteLine(numberToInt);
//int  numberToInt1 = (int)numberToInt;
//Console.WriteLine(numberToInt1);


//int a = 10;
//int b = 11;

//// Assigning new Values
//a = 40;
//b = 35;

//// Increment and Decrement

//++a;
//++b;

//b = b - 2;
//a -= 2;
//a *= 2;


//a = a + 1;
//// or
//a += 10; // Shorthand

//a = -10;
//double number = 10.5;
//Console.WriteLine(Math.Max(a,b));
//Console.WriteLine(Math.Min(a, b));
//Console.WriteLine(Math.Sqrt(49));
//Console.WriteLine(Math.Abs(a));
//Console.WriteLine(Math.Floor(number)); 
//Console.WriteLine(Math.Ceiling(number));
//Console.WriteLine(Math.Round(number));


//int sum = a + b;
//int sub = a - b;
//int mul = a * b;
//int div = a /b;
//int modulus = a % b; // remainder

//Console.WriteLine($"Addition = {sum}");
//Console.WriteLine($"Subtraction = {sub}");
//Console.WriteLine($"Multiplication = {mul}");
//Console.WriteLine($"Division = {div}");
//Console.WriteLine($"Modulus = {modulus}");


// Strings and Characters

using System.Diagnostics;
using System.Net.Security;

string name = "lAsAlle";
Console.WriteLine($"Length of the string {name.Length}");

// To change things to upper or lowercase
Console.WriteLine( name.ToUpper() );
Console.WriteLine(name.ToLower());

// To access a particular character in a string
Console.WriteLine(name[2].GetType());
Console.WriteLine($"The third character {name[2].ToString().ToUpper()}");

// vowels
Console.WriteLine(name.ToLower());    
Console.WriteLine(("aeiou").Contains("e"));

Console.WriteLine(name.ToLower().IndexOf("s"));

string newName = "Jerry Joy";
int index = newName.IndexOf("J");
int nextIndex = newName.IndexOf('J', index+1);   
Console.WriteLine(nextIndex);

Console.WriteLine(newName.Substring(nextIndex));
Console.WriteLine("Hello \nI'am \t\bJerry"); // Escape Sequence

//// Conditional Statements

//if ((10 > 9))
//{
//    Console.WriteLine("10 > 9");
//}
//if(10 != 9)
//{
//    Console.WriteLine(name);
//}


/**
 * 
 * 1. Take a User Input, ask their age,
 * if it is greater than or equal to 18, print "Hello, you are welcome", if print "Not Allowed"
 */

//Console.WriteLine("Enter your Age: ");
//string text = Console.ReadLine(); // User Input
//// string to integer
//int age = int.Parse(text); // Convert String to Int

//// If-Else Condition
//if (age < 18)
//{
//    Console.WriteLine("Not Allowed");
//}
//else
//{
//    Console.WriteLine("Hello,\nYou are Welcome!");
//}


/*
 * 1. Get a number from the user.
 * 2. Print if the number is odd or even.
 */

//Console.WriteLine("Enter a number");
//int number = int.Parse(Console.ReadLine());

//// To check for Odd or Even
//if (number % 2 == 0)
//{
//    Console.WriteLine("The number is Even");
//}
//else
//{
//    Console.WriteLine("The number is Odd");    
//}



/**
 * I have a number 31.31, it is called a devil number if the numbers to the left of the decimal
 * and the numbers to the right of the decimal shoule be same. 
 * in this case 31 is same on both the sides of the decimal.
 * write a program in c# to check the number if it is devil number or not.
 * ex - 31.31 -> is a devil number
 * 12.12 -> is a devil number
 * 10.11 -> is not a devil number
 */


double number = double.Parse(Console.ReadLine());
string converted = number.ToString();
string left = converted.Substring(0, converted.IndexOf("."));
string right = converted.Substring(converted.IndexOf(".") + 1);
if (left.Equals(right))
{
    Console.WriteLine("It is a devil number");
}
else
{
    Console.WriteLine("It is not a devil Number");
}
Console.WriteLine(left + " == " + right);