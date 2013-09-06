using UnityEngine;
using System.Collections;

public class EnemyHealthHud : BoxHud {	
	
	public override float GetWidth() {
		float tempWidth = width;
		GameObject enemy = GameObject.FindWithTag ("Enemy");
		
		float maxHealth = Utility.HealthUtility.GetMaxHealth (enemy);
		float health = Utility.HealthUtility.GetHealth (enemy);
		
		if (health > 0) {
			 tempWidth /= (maxHealth / health);
		} else {
			 tempWidth = 0;
		}

		return tempWidth; 
	}
	
	public override string GetText (){
		GameObject enemy = GameObject.FindWithTag ("Enemy");
		float maxHealth = Utility.HealthUtility.GetMaxHealth (enemy);
		float health = Utility.HealthUtility.GetHealth (enemy);
		maxHealth = Mathf.Ceil (maxHealth);
		maxHealth = Mathf.Ceil (health);
		return ( maxHealth + "/" + health);
	}
	
	public override Color GetColor()
	{
		return new Color(1,0,0,1);
	}

}
