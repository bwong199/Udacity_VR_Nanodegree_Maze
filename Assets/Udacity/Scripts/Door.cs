using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	// Create a boolean value called "locked" that can be checked in Update()

	public GameObject gameObject;

	void Update ()
	{
		if(Key.KEYFOUND){
			Unlock ();
		}
		// If the door is unlocked and it is not fully raised
		// Animate the door raising up
	}

	public void Unlock ()
	{
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, 25, gameObject.transform.position.z);
	}

	void OnMouseDown ()
	{
		if (!Key.KEYFOUND) {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
