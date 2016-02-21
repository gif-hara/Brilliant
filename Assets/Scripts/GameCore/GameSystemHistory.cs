using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// GameSystemのアクセス履歴を保持する.
	/// </summary>
	[System.Serializable]
	public class GameSystemHistory
	{
		private List<GameObject> history;

		public GameSystemHistory()
		{
			this.history = new List<GameObject>();
		}

		public void Add(GameObject systemObject)
		{
			this.history.Add(systemObject);
		}

		public GameObject Pop
		{
			get
			{
				if(this.history.Count <= 1)
				{
					Assert.IsTrue(false, "履歴が無いのにアクセスしました.");
					return null;
				}

				var result = this.history[this.history.Count - 2];
				this.history.RemoveAt(this.history.Count - 1);

				return result;
			}
		}
			
	}
}
