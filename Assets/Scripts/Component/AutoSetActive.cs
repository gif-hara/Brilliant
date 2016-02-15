using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;

namespace Bright
{
	/// <summary>
	/// 自動でSetActiveを呼び出すコンポーネント.
	/// </summary>
	public class AutoSetActive : MonoBehaviour
	{
		[SerializeField]
		private GameObject target;

		[SerializeField]
		private bool isActive;

		[SerializeField]
		private DelayTimer delay;

		[SerializeField]
		private bool loop;

		void Update()
		{
			this.delay.Update();

			if(!this.delay.Complete)
			{
				return;
			}

			this.target.SetActive(this.isActive);

			if(this.loop)
			{
				this.delay.Reset();
			}
			else
			{
				this.enabled = false;
			}
		}
	}
}
