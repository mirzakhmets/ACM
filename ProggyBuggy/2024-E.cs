/*
 * Created by SharpDevelop.
 * User: mirza
 * Date: 10/26/2024
 * Time: 3:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace E
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine().Trim());
			
			int[] xl = new int[n], xr = new int[n], yl = new int[n], yr = new int[n];
			
			for (int i = 0; i < n; ++i) {
				string[] s = Console.ReadLine().Trim().Split(' ');
				
				xl[i] = int.Parse(s[0]);
				yl[i] = int.Parse(s[1]);
				xr[i] = int.Parse(s[2]);
				yr[i] = int.Parse(s[3]);
			}
			
			int square = 0;
			
			for (int i = 0; i < 1000; ++i) {
				for (int j = 0; j < 1000; ++j) {
					bool bl = false;
					
					for (int k = 0; k < n; ++k) {
						if (i >= Math.Min(xl[k], xr[k]) && i + 1 <= Math.Max(xl[k], xr[k])
							&& j >= Math.Min(yl[k], yr[k]) && j + 1 <= Math.Max(yl[k], yr[k]))
						{
							bl = true;
							break;
						}
					}
					
					if (bl) {
						++square;
					}
				}
			}
			
			Console.WriteLine(square);			
		}
	}
}