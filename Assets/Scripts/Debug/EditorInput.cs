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
			if(Input.GetKeyUp(KeyCode.LeftArrow)){Buttons.Left.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.RightArrow)){Buttons.Right.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.UpArrow)){Buttons.Top.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.DownArrow)){Buttons.Bottom.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.Z)){Buttons.Decide.EventTrigger.OnPointerUp(null);}
			if(Input.GetKeyUp(KeyCode.X)){Buttons.Cancel.EventTrigger.OnPointerUp(null);}
		}
	}
	#endif
}
