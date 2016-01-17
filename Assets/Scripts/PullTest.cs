using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace Brilliant
{
	/// <summary>
	/// .
	/// </summary>
	public class PullTest : MonoBehaviour
	{
		public void OnPull()
		{
			var horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
			var vertical = CrossPlatformInputManager.GetAxis("Vertical");
			Debug.Log("horizontal = " + horizontal + " vertical = " + vertical);
		}
	}
}
