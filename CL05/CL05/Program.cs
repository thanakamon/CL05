﻿using System;
using System.IO;
public class IfLearning
{
    public static void Main()
    {
        Console.WriteLine("input your score: ");
        int point = int.Parse(Console.ReadLine());
        if (point < 50)
            Console.WriteLine("Grade F");
        else if (point < 60)
            Console.WriteLine("Grade D");
        else if (point < 70)
            Console.WriteLine("Grade C");
        else if (point < 80)
            Console.WriteLine("Grade B");
        else
            Console.WriteLine("Grade A");
    }
}






