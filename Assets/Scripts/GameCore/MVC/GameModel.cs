using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// ゲームシステム部分を制御しているオブジェクトを格納するコンポーネント.
	/// </summary>
	public class GameModel : SingletonMonoBehaviour<GameModel>
	{
		[SerializeField]
		private List<GameObject> systems;

		[SerializeField]
		private GameObject initializeSystem;

		private GameObject currentSystem = null;

		public GameSystemHistory History{ private set; get; }

		protected override  void Awake()
		{
			base.Awake();
			this.History = new GameSystemHistory();
		}

		void Start()
		{
			this.systems.ForEach(s => s.SetActive(false));
			this.Change(this.initializeSystem, true);
		}
			
		public static void Change(GameObject systemObject, bool addHistory)
		{
			if(Instance.currentSystem != null)
			{
				Instance.currentSystem.SetActive(false);
			}

			Instance.currentSystem = systemObject;
			Instance.currentSystem.SetActive(true);

			if(addHistory)
			{
				Instance.History.Add(systemObject);
			}
		}
	}
}
