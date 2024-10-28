/*
 * Created by SharpDevelop.
 * User: mirza
 * Date: 10/26/2024
 * Time: 3:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace A
{
	class Program
	{
		public static void Main(string[] args)
		{
			string a = Console.ReadLine().Trim();
			string b = Console.ReadLine().Trim();
			
			Console.WriteLine((a.Length + b.Length) - 3);
		}
	}
}