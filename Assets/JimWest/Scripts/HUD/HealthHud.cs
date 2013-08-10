using UnityEngine;
using System.Collections;

public class HealthHud : BoxHud {	
	
	public override float GetWidth() {
		float tempWidth = width;
		int maxHealth = Utility.HealthUtility.GetMaxHealth (player);
		int health = Utility.HealthUtility.GetHealth (player);
		
		if (health > 0) {
			 tempWidth /= ((float)maxHealth / (float)health);
		} else {
			 tempWidth = 0;
		}

		return tempWidth; 
	}
	
	public override string GetText (){
		int maxHealth = Utility.HealthUtility.GetMaxHealth (player);
		int health = Utility.HealthUtility.GetHealth (player);
		return ( maxHealth + "/" + health);
	}

}