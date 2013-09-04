using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Utility
{

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
			return 	entity.GetComponent<HealthHandler>().GetHealth();		
		}
		
		public static int GetHealth(GameObject entity) {
			return 	entity.GetComponent<HealthHandler>().GetHealth();		
		}
		
		public static int GetMaxHealth(Component entity){
				return 	entity.GetComponent<HealthHandler>().GetMaxHealth();
		}
		
		public static int GetMaxHealth(GameObject entity){
				return 	entity.GetComponent<HealthHandler>().GetMaxHealth();		
		}
		
		public static bool GetIsAlive(Component entity){
				return 	entity.GetComponent<HealthHandler>().GetIsAlive();
		}
		
		public static bool GetIsAlive(GameObject entity){
				return 	entity.GetComponent<HealthHandler>().GetIsAlive();		
		}
	}
}