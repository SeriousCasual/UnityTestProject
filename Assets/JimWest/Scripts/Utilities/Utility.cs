using UnityEngine;
using System.Collections;

namespace Utility
{
	
	public class GameUtility {
		
		private static float tempTimeScale;
	
		public static void PauseGame() {			
			tempTimeScale = Time.timeScale;
			Time.timeScale = 0.0f; 			
		}
		
		public static void UnPauseGame() {
			if (tempTimeScale != 0) {
				Time.timeScale = tempTimeScale;
			} else {
				Time.timeScale = 1.0f;
			}
		}
		
	}

	
	public class PlayerUtility {
	
		public static GameObject GetPlayer() {
			return GameObject.FindWithTag("Player");
		}
	}
	
	
	public class HealthUtility {

		public static void AddHealth(Component entity, int health) {
			HealthHandler handler = entity.GetComponent<HealthHandler>();
			if (handler) {
				handler.AddHealth(health);
			}
		}
		
		public static bool DeductHealth(Component entity, int health){	
			HealthHandler handler = entity.GetComponent<HealthHandler>();
			if (handler) {
				return handler.DeductHealth(health);
			}
			return false;
		}
		
		public static int GetHealth(Component entity) {
			return 	entity.GetComponent<HealthHandler>().health;		
		}
		
		public static int GetHealth(GameObject entity) {
			return 	entity.GetComponent<HealthHandler>().health;		
		}
		
		public static int GetMaxHealth(Component entity){
				return 	entity.GetComponent<HealthHandler>().maxHealth;
		}
		
		public static int GetMaxHealth(GameObject entity){
				return 	entity.GetComponent<HealthHandler>().maxHealth;
		}
		
	}
	
	
	public class EntityUtility {
		
		public static Entity GetEntity(GameObject entity){
			return (Entity)entity.GetComponent<Entity>();
		}
		
		public static Entity GetEntity(Component entity){
			return (Entity)entity.GetComponent<Entity>();
		}
		
	}
	
	
	
}

