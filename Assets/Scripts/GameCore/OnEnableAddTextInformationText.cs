using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでInformationTextに文字列を追加するコンポーネント.
	/// </summary>
	[RequireComponent(typeof(AddTextInformationText))]
	public class OnEnableAddTextInformationText : MonoBehaviour
	{
		void OnEnable()
		{
			GetComponent<AddTextInformationText>().Add();
		}
	}
}
