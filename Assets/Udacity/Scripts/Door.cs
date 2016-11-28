using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	// Create a boolean value called "locked" that can be checked in Update()
	public bool locked = true;
	public GameObject gameObject;

	void Update ()
	{
		// If the door is unlocked and it is not fully raised
		// Animate the door raising up
		if(locked){

		}else {
			Unlock ();
		}
	}

	public void Unlock ()
	{
		print ("Script passed to Door");
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, 25, gameObject.transform.position.z);
	}

	void OnMouseDown ()
	{
		if (locked) {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
