// See https://aka.ms/new-console-template for more information
using Session9_PropetiesAndIndexer;

Console.WriteLine("Hello, World!");
ATMPin aTMPin = new ATMPin();
aTMPin.Pin = "1232";
Console.WriteLine(aTMPin.Pin);
Console.ReadKey();