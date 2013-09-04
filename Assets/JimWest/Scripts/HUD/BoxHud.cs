using UnityEngine;
using System.Collections;

public class BoxHud : Hud
{
	internal Rect rect;
	internal float width = Screen.width / 3;
	internal Texture2D texture;
	internal Color color;
	internal GUIStyle style;
	
	public override void Start () {		
		base.Start();	
		rect = new Rect(left,top,GetWidth(), 20);
		texture = new Texture2D(128, 128);
		color = new Color(1,0,0,1);
	}
	
	/// <summary>
	/// Is this GUI visible?
	/// </summary>
	/// <value>
	/// <c>true</c> if visible; otherwise, <c>false</c>.
	/// </value>
	public bool Visible { get; set; }
	
	public virtual void OnGUI() {
		if (this.Visible)
		{
			rect.width = GetWidth ();
			style = GUI.skin.box;
			GUI.backgroundColor = GetColor();
			style.normal.background = texture;
			GUI.Box (rect , GetText(), style);
		}
	}
		
	public virtual float GetWidth() {
		return width; 
	}
	
	public virtual string GetText() {
		return ""; 
	}
	
	public virtual Color GetColor() {
		return color; 
	}

}


