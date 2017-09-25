/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/17/2015
 * Время: 12:52
 */
using System;

namespace TasKard
{
	/// <summary>
	/// Description of CheckDeck.
	/// </summary>
	public class CheckDeck
	{		
		public CheckDeck(string zn, int izn)
		{
			this.znach = zn;
			this.iznach = izn;
		}
		public string znach;
		public bool check;
		public int iznach;
	}
}
