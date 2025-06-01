// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
int b = 10; //Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
decimal d = 20.3; //Convert this value into "string" type (assign into another string type of variable)
 */

//byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
// implicite casting
byte a = 10;
short a1 = a;
Console.WriteLine("Implicite casting" +  a1);

// Explicitr casting
int b = 10;
short b1 = (short)b;
Console.WriteLine("Explicite casting" + b1);

//parse
string c = "10.34";
double c1 = double.Parse(c);
Console.WriteLine("Parse" + c1);

//Tryparse
bool isConvertable = decimal.TryParse(c, out decimal result);
if(isConvertable)
{
    Console.WriteLine("TryParse " + result);
} else
{
    Console.WriteLine("Cannot cnvert the method");
}

//Conversion Method
decimal d = 11.56M;
string i = System.Convert.ToString(d);
Console.WriteLine("Conversion Method" + i);