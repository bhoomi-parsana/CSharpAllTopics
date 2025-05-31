//Formula: PI* radius *radius

//PI is a constant value, approximately equal to 3.14159, which is 
//equal to the ratio of the circumference of any circle to its diameter.
using System;

public class AreaOfCircle
{
    public double calculateAreaofCircle(int radious)
    {
        return Math.PI * radious * radious;
    }
}

/* feet to centemeter converter */

public class FeetToCentimeter()
{
    public double calculateFeettoCentimeter()
    {
        int feet = 5, inches = 7;

        //process
        //find number of inches based on number of feet
        int total_inches = (feet * 12) + inches;
        //find number of centimeters based on number of inches
        double centimeters = total_inches * 2.54;

        return centimeters;
    }
}
/*
If the number's last three digits are greater than or equal to 500; it should "round up" the number.

If the number's last three digits are less than 500; it should "round down" the number.

If the number is less than 500; it should round up to 1000.
*/

public class NearestThousands
{
    public int CalculateNearestThousands(int number)
    {
        int reminder = number % 1000;
        int dividend = number / 1000;
        if (reminder < 500)
        {
            return dividend * 1000;
        } else
        {
            return (dividend+1) *1000;
        }
    }
}

/* onvert seconds to day */
public class ConvertSecondToDay
{
    public void CalculateConvertSecondToDay(int input)
    {
        int days = input / (24 * 3600);
        int new_seconds = input - (days * 24 * 3600);
        Console.WriteLine($"remaining seconds {new_seconds}");

        int hours = new_seconds / 3600;
        new_seconds -= (hours*3600);

        Console.WriteLine($"remaining seconds {new_seconds}");

        int minutes = new_seconds / 60;
        new_seconds -= (minutes*60);
        Console.WriteLine($"remaining seconds {new_seconds}");

        Console.WriteLine($"{days} days {hours} hours {minutes} minutes {new_seconds} seconds");

    }
}


/*
Height categories:

Height is less than 150 cm = "Dwarf"

Height is between 150 cm and 165 cm = "Average height"

Height is between 165 cm and 195 cm = "Tall"

Height is above 195 cm = "Abnormal height"
 
*/
public class PersionHeight
{
    public string CategoryOfPersion(double height)
    {
        height = height * 2.54;
        if(height < 150)
        {
            return "Dwarf";
        } else if (height >150 && height<165) {
            return "Average height";
        } else if (height >165 && height < 195)
        {
            return "Tall";
        } else
        {
            return "Abnormal height";
        }
    }
}

/*Check the largest of three number */
public class LargestOfThreeNumber
{
    public int FindTheLagestOfThreeNumber(int num1, int num2, int num3)
    {
        int largest = num1;
        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }
        return largest;
    }
}

/* Pattern Printing 
 Write a C# program to print the following output:

1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3
10 9 8 7 6 5 4 3 2 1
1 2 3 4 5 6 7 9 10
 */

public class PatternPrinting
{
    public void PrintPattern()
    {
        for (int j = 1; j < 4; j++)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}