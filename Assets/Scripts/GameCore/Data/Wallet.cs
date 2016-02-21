using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// 財布クラス.
	/// </summary>
	public class Wallet
	{
		private int money;

		public Wallet()
		{
			this.money = 0;
		}

		public void Add(int value)
		{
			this.money += value;
		}

		public void Use(int value)
		{
			this.money -= value;
		}

		public bool IsEnough(int value)
		{
			return this.money >= value;
		}
	}
}
