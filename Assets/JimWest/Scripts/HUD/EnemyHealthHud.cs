using UnityEngine;
using System.Collections;

public class EnemyHealthHud : BoxHud {	
	
	public override float GetWidth() {
		float tempWidth = width;
		GameObject enemy = GameObject.FindWithTag ("Enemy");
		
		int maxHealth = Utility.HealthUtility.GetMaxHealth (enemy);
		int health = Utility.HealthUtility.GetHealth (enemy);
		
		if (health > 0) {
			 tempWidth /= ((float)maxHealth / (float)health);
		} else {
			 tempWidth = 0;
		}

		return tempWidth; 
	}
	
	public override string GetText (){
		GameObject enemy = GameObject.FindWithTag ("Enemy");
		int maxHealth = Utility.HealthUtility.GetMaxHealth (enemy);
		int health = Utility.HealthUtility.GetHealth (enemy);
		return ( maxHealth + "/" + health);
	}

}
