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
	
	public virtual float GetTop()
	{
		return this.top;
	}
	
	protected void SetTop(float top)
	{
		this.top = top;
	}
	
	public virtual float GetLeft()
	{
		return left;
	}
	
	protected void SetLeft(float left)
	{
		this.left = left;
	}
	
}


