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

		private static InformationText instance;

		void Awake()
		{
			Assert.IsNull(instance, "InformationTextはシングルトンです.");
			instance = this;
		}

		public static void Add(string message)
		{
			instance.text.text = message + System.Environment.NewLine + instance.text.text;
		}
	}
}
