using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// このゲームのボタン類を制御するコンポーネント.
	/// </summary>
	public class Buttons : MonoBehaviour
	{
		public static Buttons Instance{ private set; get; }

		public static BrilliantButton Left{ get{ return Instance.left; } }
		[SerializeField]
		private BrilliantButton left;

		public static BrilliantButton Right{ get{ return Instance.right; } }
		[SerializeField]
		private BrilliantButton right;

		public static BrilliantButton Top{ get{ return Instance.top; } }
		[SerializeField]
		private BrilliantButton top;

		public static BrilliantButton Bottom{ get{ return Instance.bottom; } }
		[SerializeField]
		private BrilliantButton bottom;

		public static BrilliantButton Decide{ get{ return Instance.decide; } }
		[SerializeField]
		private BrilliantButton decide;

		public static BrilliantButton Cancel{ get{ return Instance.cancel; } }
		[SerializeField]
		private BrilliantButton cancel;

		void Awake()
		{
			Assert.IsNull(Instance, "Buttonsはシングルトンです.");
			Instance = this;
		}

		public static BrilliantButton Get(GameDefine.ButtonType type)
		{
			switch(type)
			{
			case GameDefine.ButtonType.Left:
				return Instance.left;
			case GameDefine.ButtonType.Right:
				return Instance.right;
			case GameDefine.ButtonType.Top:
				return Instance.top;
			case GameDefine.ButtonType.Bottom:
				return Instance.bottom;
			case GameDefine.ButtonType.Decide:
				return Instance.decide;
			case GameDefine.ButtonType.Cancel:
				return Instance.cancel;
			}

			Assert.IsTrue(false, "不正な値です type = " + type);
			return null;
		}
	}
}
