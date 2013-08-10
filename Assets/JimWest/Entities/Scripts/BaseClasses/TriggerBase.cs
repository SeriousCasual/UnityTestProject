using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;
using System.ComponentModel;

public class TriggerBase : Entity {	
		
	//[SerializeField]
	public List<EntityMethodPair> targets = new List<EntityMethodPair>();	
	public bool onlyOnce;
	internal bool triggered;	
	
	void Start () {
	}
	
	void Update () {
	}
	
	internal virtual void Trigger(Collider other){
		// check if trigger is ok
		if (isEnabled & (!onlyOnce | (onlyOnce && !triggered))) {			

			// call the method via reflections invoke
			foreach (EntityMethodPair pair in targets) {
						// get the function from the string
				if (pair.method != "No Method") {				
					pair.target.GetType ()
        				.GetMethod(pair.method, BindingFlags.Instance |BindingFlags.NonPublic | BindingFlags.Public)
        				.Invoke(pair.target, new object[0]);
				}
			}
			
		}	
			
		triggered = true;
	}
	
	
}
