using UnityEngine;
using System.Collections;

public class XP : MonoBehaviour {
	
	public float xp = 0;

	// Use this for initialization
	void Start () {
		xp = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void GetXp() {	
		return xp;
	}
	
	public void AddXp(float xpToAdd)
	{
		xp += xpToAdd
	}

}
