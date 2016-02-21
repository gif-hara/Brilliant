using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでIndexHolderからImageを設定するコンポーネント.
	/// </summary>
	public class OnEnableSetImageFromIndexHolder : MonoBehaviour
	{
		[SerializeField]
		private IndexHolder indexHolder;

		[SerializeField]
		private ModifiedIndexSetImage imageSetter;

		void OnEnable()
		{
			this.imageSetter.OnModifiedIndex(this.indexHolder.Index);
		}
	}
}
