﻿using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int value = 800000000;
        
        try
        {
            checked
            {
                int square = value * value;
                Console.WriteLine("{0} ^ 2 = {1}", value, square);
            }
            }
            
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
    }
}
    
