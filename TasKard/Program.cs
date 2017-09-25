/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/17/2015
 * Время: 12:03
 */
using System;

namespace TasKard
{
	class Program
	{
		public static void Main(string[] args)
		{			
			// TODO: Implement Functionality Here
			d.PrinDeck();
			Console.WriteLine("Нажмите любую кнопку, чтобы перетасовать колоду или E для выхода");
			while(Console.ReadLine().ToUpper() != "E")
			{				
				d.NewTasDeck();
				d.PrinDeck();
				Console.WriteLine("Нажмите любую кнопку, чтобы перетасовать колоду или E для выхода");
			}
		}
		static Deck d = new Deck();
	}
}