using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using System.Linq;
using System;

public class Entity : MonoBehaviour {
	
	public bool isEnabled = true;
	
	[HideInInspector]
	public static string noFunctionString = "No function";
	
	internal string[] ignoreMethods = new string[] {"Start", "Update"};

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	[Callable]
	public virtual void Activate() {	
		isEnabled = true;
	}
	
	[Callable]
	public virtual void Deactivate() {
		isEnabled = false;
	}
	
	[Callable]
	public virtual void Toggle() {	
		isEnabled = !isEnabled;
	}
	
	// returns callable methods, for triggers etc
	public string[] GetMethodList() {
		
		string [] tempMethods =
	        this.GetType()
	        .GetMethods(BindingFlags.Instance| BindingFlags.Public | BindingFlags.NonPublic)			
			.Where(m => m.GetCustomAttributes(typeof(Callable), false).Length > 0)
	        .Where(x => !ignoreMethods.Any(n => n == x.Name)) // Don't list methods in the ignoreMethods array (so we can exclude Unity specific methods, etc.)
	        .Select(x => x.Name)
	        .ToArray();
				
		if (tempMethods.Length > 0) {
			// sort the list					
			Array.Sort<string> (tempMethods);
		}
		
		return tempMethods;
	}
	
	
}
