using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// このゲームのボタン類を制御するコンポーネント.
	/// </summary>
	public class GameController : MonoBehaviour
	{
		private static GameController instance;

		public static BrilliantButton Left{ get{ return instance.left; } }
		[SerializeField]
		private BrilliantButton left;

		public static BrilliantButton Right{ get{ return instance.right; } }
		[SerializeField]
		private BrilliantButton right;

		public static BrilliantButton Top{ get{ return instance.top; } }
		[SerializeField]
		private BrilliantButton top;

		public static BrilliantButton Bottom{ get{ return instance.bottom; } }
		[SerializeField]
		private BrilliantButton bottom;

		public static BrilliantButton Decide{ get{ return instance.decide; } }
		[SerializeField]
		private BrilliantButton decide;

		public static BrilliantButton Cancel{ get{ return instance.cancel; } }
		[SerializeField]
		private BrilliantButton cancel;

		public static List<BrilliantButton> List{ get{ return instance.list; } }
		private List<BrilliantButton> list;

		void Awake()
		{
			Assert.IsNull(instance, "Buttonsはシングルトンです.");
			instance = this;

			this.list = new List<BrilliantButton>();
			this.list.Add(this.left);
			this.list.Add(this.right);
			this.list.Add(this.top);
			this.list.Add(this.bottom);
			this.list.Add(this.decide);
			this.list.Add(this.cancel);
		}

		public static BrilliantButton Get(GameDefine.ButtonType type)
		{
			switch(type)
			{
			case GameDefine.ButtonType.Left:
				return instance.left;
			case GameDefine.ButtonType.Right:
				return instance.right;
			case GameDefine.ButtonType.Top:
				return instance.top;
			case GameDefine.ButtonType.Bottom:
				return instance.bottom;
			case GameDefine.ButtonType.Decide:
				return instance.decide;
			case GameDefine.ButtonType.Cancel:
				return instance.cancel;
			}

			Assert.IsTrue(false, "不正な値です type = " + type);
			return null;
		}
	}
}
