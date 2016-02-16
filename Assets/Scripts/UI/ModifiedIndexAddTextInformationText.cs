using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderのIndexの値が変更された際にTextInformationに文字列を追加するコンポーネント.
	/// </summary>
	public class ModifiedIndexAddTextInformationText : MonoBehaviour, IReceiveModifiedIndexHolderIndex
	{
		[SerializeField]
		private List<string> messages;

		public void OnModifiedIndex(int index)
		{
			InformationText.Add(this.messages[index]);
		}
	}
}
