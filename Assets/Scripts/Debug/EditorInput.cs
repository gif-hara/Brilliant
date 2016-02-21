using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System;
using System.Collections.Generic;

namespace Brilliant
{
	#if UNITY_EDITOR
	/// <summary>
	/// UnityEditor用のインプット制御コンポーネント.
	/// </summary>
	public class EditorInput : MonoBehaviour
	{
		void Update()
		{
			if(Input.GetKeyUp(KeyCode.LeftArrow)){GameController.Left.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.RightArrow)){GameController.Right.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.UpArrow)){GameController.Top.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.DownArrow)){GameController.Bottom.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.Z)){GameController.Decide.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.X)){GameController.Cancel.EventTrigger.OnPointerUp(null);}
		}
	}
	#endif
}
