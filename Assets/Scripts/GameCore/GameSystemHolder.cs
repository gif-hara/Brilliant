using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// ゲームシステムを格納しているゲームオブジェクトを保持するコンポーネント.
	/// </summary>
	public class GameSystemHolder : SingletonMonoBehaviour<GameSystemHolder>
	{
		[SerializeField]
		private List<GameObject> systems;

		[SerializeField]
		private GameObject initializeSystem;

		void Start()
		{
			this.Change(this.initializeSystem);
		}

		public static void Change(GameObject systemObject)
		{
			instance.systems.ForEach((s) => s.SetActive(false));
			systemObject.SetActive(true);
		}
	}
}
