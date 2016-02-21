using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

/// <summary>
/// Color32拡張クラス.
/// </summary>
public static class Color32Extensions
{
	public static string ToHex(this Color32 self)
	{
		return self.r.ToString("X2") + self.g.ToString("X2") + self.b.ToString("X2") + self.a.ToString("X2");
	}
}
