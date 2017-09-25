/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/17/2015
 * Время: 12:04
 */
using System;
using System.Collections.Generic;

namespace TasKard
{
	/// <summary>
	/// Description of Deck.
	/// </summary>
	public class Deck
	{
		#region construct
		public Deck()
		{
			this.Typedeck = TypeDeck.c52;
			this.CountCard = 52;
			this.DeckT = new CheckDeck[this.CountCard];
			this.SetDefZnach();
			this.SetDeck();			
		}
		#endregion
		#region others
		public enum TypeDeck {c52 = 52,c36 = 36};
		List<CheckDeck> cd = new List<CheckDeck>();
		#endregion
		#region private param
		private TypeDeck _typedeck;
		private int _countcard;
		private CheckDeck[] _deck;
		#endregion			
		#region public param
		public TypeDeck Typedeck
		{
			get { return this._typedeck; }
			set { this._typedeck = value; }
		}
		public int CountCard
		{
			get { return this._countcard; }
			set { this._countcard = value; }
		}
		public CheckDeck[] DeckT
		{
			get { return this._deck; }
			set { this._deck = value; }
		}
		#endregion
		#region private procedure
		/// <summary>
		/// Генерируеться основная колода
		/// </summary>
		void SetDeck()
		{
			Random rnd = new Random();
			int tmp = 0;
			string str;
			for(int x = 0; x < this.DeckT.Length; x++)
			{
				while(1==1)
				{
					tmp = rnd.Next(0,this.CountCard+1);
					if(!this.CheckEl(tmp, out str))
					{						
						this.DeckT[x] = new CheckDeck(str,tmp);
						break;
					}	
				}
			}
			rnd = null;
		}
		/// <summary>
		/// Заполняеться временная колода
		/// </summary>
		void SetDefZnach()
		{
			if(this.Typedeck == TypeDeck.c52)
			{
				cd.Add(new CheckDeck("2П",0));
				cd.Add(new CheckDeck("3П",1));
				cd.Add(new CheckDeck("4П",2));
				cd.Add(new CheckDeck("5П",3));
				
				cd.Add(new CheckDeck("2К",4));
				cd.Add(new CheckDeck("3К",5));
				cd.Add(new CheckDeck("4К",6));
				cd.Add(new CheckDeck("5К",7));
				
				cd.Add(new CheckDeck("2Ч",8));
				cd.Add(new CheckDeck("3Ч",9));
				cd.Add(new CheckDeck("4Ч",10));
				cd.Add(new CheckDeck("5Ч",11));
				
				cd.Add(new CheckDeck("2Б",12));
				cd.Add(new CheckDeck("3Б",13));
				cd.Add(new CheckDeck("4Б",14));
				cd.Add(new CheckDeck("5Б",15));
			}
			cd.Add(new CheckDeck("6П",16));
			cd.Add(new CheckDeck("7П",17));
			cd.Add(new CheckDeck("8П",18));
			cd.Add(new CheckDeck("9П",19));
			cd.Add(new CheckDeck("10П",20));
			cd.Add(new CheckDeck("ВП",21));
			cd.Add(new CheckDeck("ДП",22));
			cd.Add(new CheckDeck("КП",23));
			cd.Add(new CheckDeck("ТП",24));
			cd.Add(new CheckDeck("6К",25));
			cd.Add(new CheckDeck("7К",26));
			cd.Add(new CheckDeck("8К",27));
			cd.Add(new CheckDeck("9К",28));
			cd.Add(new CheckDeck("10К",29));
			cd.Add(new CheckDeck("ВК",30));
			cd.Add(new CheckDeck("ДК",31));
			cd.Add(new CheckDeck("КК",32));
			cd.Add(new CheckDeck("ТК",33));
			
			cd.Add(new CheckDeck("6Ч",34));
			cd.Add(new CheckDeck("7Ч",35));
			cd.Add(new CheckDeck("8Ч",36));
			cd.Add(new CheckDeck("9Ч",37));
			cd.Add(new CheckDeck("10Ч",38));
			cd.Add(new CheckDeck("ВЧ",39));
			cd.Add(new CheckDeck("ДЧ",40));
			cd.Add(new CheckDeck("КЧ",41));
			cd.Add(new CheckDeck("ТЧ",42));
			cd.Add(new CheckDeck("6Б",43));
			cd.Add(new CheckDeck("7Б",44));
			cd.Add(new CheckDeck("8Б",45));
			cd.Add(new CheckDeck("9Б",46));
			cd.Add(new CheckDeck("10Б",47));
			cd.Add(new CheckDeck("ВБ",48));
			cd.Add(new CheckDeck("ДБ",49));
			cd.Add(new CheckDeck("КБ",50));
			cd.Add(new CheckDeck("ТБ",51));
		}
		/// <summary>
		/// Проверка элемента, был использован или нет, если нет, то помечаем, что да и возвращаем фалс, если нет, то возвращаем тру 
		/// </summary>
		/// <param name="el">Элемент для сравнения</param>
		/// <returns>True - использован False - не использован</returns>
		bool CheckEl(int el, out string str)
		{			
			str = "";
			foreach(CheckDeck c in cd)
			{
				if(c.iznach == el)
				{
					if(c.check == false)
					{						
						c.check = true;
						str = c.znach;
						return false;
					}
					else
					{
						return true;
					}
				}
			}
			return true;
		}
		/// <summary>
		/// Очистка выбраных карт
		/// </summary>
		private void ClearCD()
		{
			foreach(CheckDeck c in cd)
			{
				c.check = false;
			}
		}
		#endregion
		#region public param
		/// <summary>
		/// Напечатать колоду
		/// </summary>
		public void PrinDeck()
		{
			foreach(var v in this.DeckT)
			{				
				Console.Write(v.znach + " ");
			}
		}
		/// <summary>
		/// Перетасовать колоду
		/// </summary>
		public void NewTasDeck()
		{
			ClearCD();
			SetDeck();
		}		
		#endregion
	}
}
