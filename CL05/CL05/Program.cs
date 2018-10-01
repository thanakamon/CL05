using System;
using System.IO;
public class switchLearning
{
    public static void Main()
    {
        Console.Write("Input day name : ");
        string day = Console.ReadLine();
        string message;
        switch (day)
        {
            case "sun":
                message = "sun is Sunday, color Red";
                break;
            case "mon":
                message = "mon is Monday, color Yellow";
                break;
            case "tue":
                message = "tue is Tuesday, color Pink";
                break;
            case "wed":
                message = "wed is Wednesday, color Green";
                break;
            case "thu":
                message = "thu is Thursday, color Orange";
                break;
            case "fri":
                message = "fri is Friday, color Blue";
                break;
            case "sat":
                message = "sat is Saturday, color Purple";
                break;
            default:
                message = "Error";
                break;
        }
        Console.WriteLine(message);
    }
}
