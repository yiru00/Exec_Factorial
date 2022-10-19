using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入一個數值: ");
			string input=Console.ReadLine();
			bool isInt=int.TryParse(input, out int num); // true => int num=Convert.Int32(input);
			int start = 1;
			if (isInt == false)
			{
				Console.WriteLine("錯誤，請輸入數字");
				return;	
			}
			for (int i =1 ; i <=num; i++)
			{
				start=start *i;
			}
			Console.WriteLine($"{num}! = {start}");

		}
	}
}
