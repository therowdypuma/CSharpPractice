﻿using System;
using System.Timers;

class Program
{

	static void Main(string[] args)
	{
		int[] arr = { 19, 10, 75, 52 };

		try
		{

			for (int i = 0; i < 8; i++)
			{
				Console.WriteLine(arr[i] / arr[i + 1]);
			}
		}

		// Catch block for invalid array access
		catch (IndexOutOfRangeException e)
		{

			Console.WriteLine("An Exception has occurred : {0}", e.Message);
		}

		// Catch block for attempt to divide by zero
		catch (DivideByZeroException e)
		{

			Console.WriteLine("An Exception has occurred : {0}", e.Message);
		}

		// Catch block for value being out of range
		catch (ArgumentOutOfRangeException e)
		{

			Console.WriteLine("An Exception has occurred : {0}", e.Message);
		}

		// Finally block
		// Will execute irrespective of the above catch blocks
		finally
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(" {0}", arr[i]);
			}
		}

        //Timer myTimer = new Timer(2000);
        //myTimer.Elapsed += MyTimer_Elapsed;


        //myTimer.Start();
        Console.ReadLine();
	}


	//private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
	//{
	//	Console.WriteLine("Elapsed : {0:HH:mm:ss:fff}", e.SignalTime);
	//}


}
