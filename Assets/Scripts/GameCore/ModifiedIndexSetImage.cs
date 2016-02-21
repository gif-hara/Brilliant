using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderのIndexの値が変更された際にViewのImageを設定するコンポーネント.
	/// </summary>
	public class ModifiedIndexSetImage : MonoBehaviour, IReceiveModifiedIndexHolderIndex
	{
		[SerializeField]
		private List<Sprite> sprites;

		public void OnModifiedIndex(int index)
		{
			GameView.Change(GameDefine.ViewType.Image);
			var image = GameView.Image;
			image.GetComponent<Image>().sprite = this.sprites[index];
		}
	}
}
