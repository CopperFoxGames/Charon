using UnityEngine;
using System.Collections;

public class Engine_Stats : Engine_Base {

	[System.Serializable]
	public class Stats {
		public int _str = 10;//governs physical based things and carry weight
		public int _end = 10;//governs health and carry weight
		public int _dex = 10;//governs accuracy and evasion
		public int _int = 10;//governs energy based things

	}
	public Stats stats = new Stats();

	[System.Serializable]
	public class MiscStats {
		public string displayName = "Default Name";//the display name of the object
		public int Health = 100;//the current amm of health
		public int MaxHealth = 100;//the max amm of health
		public int XP = 0;//the curr amm of xp
		public int XPMax = 100;//the max amm of xp
		public float XPCurve = 1.1f;//how much the max exp is multiplyed by each lv up
		public int LV = 1;//the current level
		public int LVCap = 100;//the level cap
		public int StatPoints = 0;//how many statpoints the character has
		public int StatPointsGainPerLevel = 2;//how much statpoints you gain per level
	}
	public MiscStats misc = new MiscStats();

	// Use this for initialization
	void Start () {

		print ("Starting");
		Initilize ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public virtual void Initilize() {

	}
}
