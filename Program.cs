/*
 * Created by SharpDevelop.
 * User: ramazan
 * Date: 6/6/2018
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace altyaziconvert
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(Environment.CurrentDirectory);
			string[] files = Directory.GetFiles(Environment.CurrentDirectory+"\\");
			foreach (string element in files) {
				if (element.Contains(".srt")) {
					Console.WriteLine(element);
					File.AppendAllText(element+"DR",File.ReadAllText(element,Encoding.GetEncoding("iso-8859-9")));
				}
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}