/*
 * Created by SharpDevelop.
 * User: mirza
 * Date: 10/26/2024
 * Time: 3:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace D
{
	class Program
	{
		public static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			
			int[] pa = new int[256], pb = new int[256];
			
			for (int i = 0; i < 256; ++i) {
				pa[i] = pb[i] = 0;
			}
			
			for (int i = 0; i < a.Length; ++i) {
				++pa[(int) a[i]];
			}

			for (int i = 0; i < b.Length; ++i) {
				++pb[(int) b[i]];
			}	
			
			if (a.Length != b.Length) {
				Console.WriteLine("AUTHENTIC");
			} else {
				bool c = true;
				
				for (int i = 0; i < 256; ++i) {
					c = c && (pa[i] == pb[i]);
				}
				
				if (c) {
					Console.WriteLine("PLAGIARISM");
				} else {
					Console.WriteLine("AUTHENTIC");
				}
			}
		}
	}
}