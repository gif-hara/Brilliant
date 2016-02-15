using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// InformationTextに文字列を追加するコンポーネント.
	/// </summary>
	public class AddTextInformationText : MonoBehaviour
	{
		[SerializeField]
		private string message;

		public void Add()
		{
			InformationText.Add(this.message);
		}
	}
}
