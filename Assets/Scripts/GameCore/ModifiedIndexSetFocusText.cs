using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// .
	/// </summary>
	public class ModifiedIndexSetFocusText : MonoBehaviour, IReceiveModifiedIndexHolderIndex
	{
		[SerializeField]
		private Text text;

		[SerializeField]
		private List<string> messages;

		[SerializeField]
		private string focusText;

		public void OnModifiedIndex(int index)
		{
			string result = "";
			for(int i=0, imax=this.messages.Count; i<imax; i++)
			{
				if(i == index)
				{
					result += this.focusText;
				}

				result += this.messages[i] + System.Environment.NewLine;
			}

			this.text.text = result;
		}

	}
}
