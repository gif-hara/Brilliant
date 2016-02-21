using UnityEngine;
using UnityEngine.Assertions;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// ゲームで扱うデータ類を定義するクラス.
	/// </summary>
	public static class GameDefine
	{
		public enum ButtonType : int
		{
			Left,
			Right,
			Top,
			Bottom,
			Decide,
			Cancel,
		}

		public enum ViewType : int
		{
			Image,
			MainMenu,
		}
	}
}
