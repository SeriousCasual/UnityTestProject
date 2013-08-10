using UnityEngine;
using System.Collections;

public class Platform : Entity {

    void OnTriggerEnter(Collider other){
		other.transform.parent = transform.parent;
    }
     
    void OnTriggerExit(Collider other){
    	other.transform.parent = null;
    }
}
