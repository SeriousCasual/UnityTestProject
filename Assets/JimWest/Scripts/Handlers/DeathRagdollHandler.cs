using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Collider))]

public class DeathRagdollHandler : MonoBehaviour {

	public bool ragdolling = false;
	public float ragdollDuration = 1.5f;
	public DateTime ragdollStopTime = DateTime.MinValue;
	
	void Update()
	{
		if (this.ragdolling && DateTime.Now >= this.ragdollStopTime)
		{
			// Stop Ragdolling and destroy self.
		}
	}
	
	void StartRagdoll()
	{
		this.ragdollStopTime = DateTime.Now + this.ragdollStopTime;
		
		// Start ragdolling and suppress input
	}
	
	public bool GetIsRagdolling()
	{
		return ragdolling;
	}
	
}