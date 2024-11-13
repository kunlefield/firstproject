using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" my name and id ");
            Console.WriteLine("Hello World!");


 

//Console.WriteLine(Fib(5));

 

float num1 = 12f; // output 12.0

 double num2 = 345; // 345.0

double num3 = 345d; // 345.0

decimal num4 = 56767m; // 56767.0

// Console.WriteLine(num1 + num2);

 

long num5 = 78963986982898991;

bool check = false;

bool check1 = true;

char character1 = 'a';

long num6 = 23564;

int num7 = Convert.ToInt32(Int32.MaxValue);

 

string name = "Mr Kunle";

int age = 30;

string country = "Nigeria";

string course = "Education";

string school = "LASU";

int companies = 3;

Console.WriteLine("My name is " + name + "," + "i am " +

     age + " years old" + " from " + country + " i studied " + course

     + " from " + school + " and i am currently working with " + companies

     + " companies");

 

int a = 1;

int b = 2;

// Which one is greater?

bool greaterAB = (a > b); // False

// Is 'a' equal to 1?

bool equalA1 = (a == 1); // True

// Print the results on the console

if (greaterAB)

{

     Console.WriteLine("A > B");  // greaterAB must be true to print this

}

else

{

     Console.WriteLine("A <= B"); // First

}

Console.WriteLine("greaterAB = " + greaterAB); // Second

Console.WriteLine("equalA1 = " + equalA1); // Third

 

 

// Declare a variable

char ch = '}';

// Print the results on the console

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

ch = 'b';

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

ch = 'A';

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

 

object container1 = 5;

object container2 = "Five";

// Print the results on the console

Console.WriteLine("The value of container1 is: " + container1);

Console.WriteLine("The value of container2 is: " + container2);

 

bool check2 = false;

Console.WriteLine(Convert.ToInt32(check2));

string information = " Debit Alert\n\n Account Name\u003A \'Adebayo\' \\ \"Abdullahi\"  \n\n Account Number\u003A 1234***882\n\n Bank\u003A UBA \t\t Bank\n\n Amount\u003A #500\n\n Balance\u003A #1500";

Console.WriteLine(information);

 Console.WriteLine(" " +"\u04A7");

 Console.WriteLine(" " + "\u003A");

 

string path = "C:\\Windows\\Notepad.exe";

Console.WriteLine(path);

string verbatim = @"The \ is not escaped as \\.I am at a new line.";

// Console.WriteLine(verbat
// sbyte, byte, short, ushort, int, uint, long
// and ulong in order to assign them the following values: 52,130; -115;
// 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
// 1990; 123456789123456789.

 // Declare variable
 int num11 = 52;
 int num22 = 97;
 int num33 = 112;
 int num44 = 130;
 
Console.WriteLine($"{num11 + num22 + num33 + num44}");
 
 
 
int x = 'a';



 






 

 
        }
    }
}
































