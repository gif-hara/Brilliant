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

		[SerializeField]
		private Color32 focusColor;

		public void OnModifiedIndex(int index)
		{
			string result = "";
			for(int i=0, imax=this.messages.Count; i<imax; i++)
			{
				if(i == index)
				{
					result += "<color=#" + this.focusColor.ToHex() + ">";
					result += this.focusText;
				}

				result += this.messages[i];

				if(i == index)
				{
					result += "</color>";
				}

				result += System.Environment.NewLine;
			}

			this.text.text = result;
		}

	}
}
