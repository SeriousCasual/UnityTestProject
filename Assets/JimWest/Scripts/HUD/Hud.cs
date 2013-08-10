using UnityEngine;
using System.Collections;
	
public class Hud: MonoBehaviour {

	internal GameObject player;
	public float top;
	public float left;
	
	// Use this for initialization
	public virtual void Start () {
		player =  Utility.PlayerUtility.GetPlayer ();	
	}
	
}


