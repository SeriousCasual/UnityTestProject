using UnityEngine;
using System.Collections;

public class PauseTest : Entity {

	void OnTriggerEnter(Collider other) {
		Utility.GameUtility.PauseGame();	
	}
	
}
