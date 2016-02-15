using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Brilliant
{
	/// <summary>
	/// 情報テキストを制御するコンポーネント.
	/// </summary>
	public class InformationText : MonoBehaviour
	{
		[SerializeField]
		private Text text;

		public static InformationText Instance{ private set; get; }

		void Awake()
		{
			Assert.IsNull(Instance, "InformationTextはシングルトンです.");
			Instance = this;
		}

		public static void Add(string message)
		{
			Instance.text.text = message + System.Environment.NewLine + Instance.text.text;
		}
	}
}
