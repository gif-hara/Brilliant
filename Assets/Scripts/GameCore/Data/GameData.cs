using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// ゲームデータ.
	/// </summary>
	public class GameData
	{
		public static GameData Instance
		{
			get
			{
				instance = instance ?? new GameData();

				return instance;
			}
		}
		private static GameData instance = null;

		public MasterData MasterData{ private set; get; }

		public PlayerData PlayerData{ private set; get; }

		private GameData()
		{
			this.MasterData = Resources.Load<MasterData>("MasterData/MasterData");
			this.PlayerData = new PlayerData();
		}
	}
}
