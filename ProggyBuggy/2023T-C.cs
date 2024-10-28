/*
 * Created by SharpDevelop.
 * User: mirza
 * Date: 10/26/2024
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chocolate
{
	class Program
	{
		public static bool Can(int who, int n, int m) {
			return (n % 2) != 0 && (m % 2) != 0;
		}
		
		public static void Main(string[] args)
		{
			string[] s = Console.ReadLine().Split(' ');
			
			int n = int.Parse(s[0]), m = int.Parse(s[1]);

			if (!Can(1, n, m))
				Console.WriteLine("Proggy");
			else
				Console.WriteLine("Buggy");
		}
	}
}