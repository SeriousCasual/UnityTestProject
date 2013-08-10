using UnityEngine;
using System.Collections;

public class HealthHandler : MonoBehaviour {
	
	public int maxHealth = 100;
	public int health = 100;
	
	public int regenHealth = 0;
	public float regenSpeed = 1f;
	private float nextRegen = 0.0f;
	
	public bool invincible = false;
	public bool dead = false;


	void Start () {
	
	}
	
	void Update () {
		if (regenHealth > 0) {
			
			if (health < maxHealth) {				
							
				if (nextRegen == 0.0f) {
					nextRegen = Time.time + regenSpeed;
				} else if (Time.time > nextRegen) {
					// regen health
					Debug.Log ("Regen");
					this.health = Mathf.Min (this.health + regenHealth, maxHealth);
					nextRegen = Time.time + regenSpeed;
				}
				
			}
		}
	}
	
	public void AddHealth(int health) {		
		// not greater than maxHealth
		this.health = Mathf.Min (this.health + health, maxHealth);		
	}
	
	public bool DeductHealth(int damage) {	
		if (!invincible) {
			// no negative health
			this.health = Mathf.Max (this.health - damage, 0);
		}
		
		dead = this.health <= 0;
			
		// returns true if died
		return dead;
	}

}
