using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// Viewを保持するコンポーネント.
	/// </summary>
	public class ViewHolder : SingletonMonoBehaviour<ViewHolder>
	{
		public static GameObject Image{ get{ return Instance.image; } }
		[SerializeField]
		private GameObject image;

		public static GameObject MainMenu{ get{ return Instance.mainMenu; } }
		[SerializeField]
		private GameObject mainMenu;

		private GameObject currentView = null;

		private List<GameObject> systems = new List<GameObject>();

		void Awake()
		{
			base.Awake();
			this.systems.Add(this.image);
			this.systems.Add(this.mainMenu);
		}

		public static void Change(GameDefine.ViewType viewType)
		{
			Instance.SetCurrentView(Instance.systems[(int)viewType]);
		}

		private void SetCurrentView(GameObject view)
		{
			this.DeactiveCurrentView();
			this.currentView = view;
			this.currentView.SetActive(true);
		}

		private void DeactiveCurrentView()
		{
			if(this.currentView == null)
			{
				return;
			}
			this.currentView.SetActive(false);
		}
	}
}
