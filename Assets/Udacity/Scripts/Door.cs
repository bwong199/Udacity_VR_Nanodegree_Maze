﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	// Create a boolean value called "locked" that can be checked in Update()

	public GameObject gameObject;
	public AudioClip audioClipDoorOpen;
	public AudioClip audioClipDoorClose;
	void Update ()
	{

		// If the door is unlocked and it is not fully raised
		// Animate the door raising up
	}

	public void Unlock ()
	{
		if (Key.KEYFOUND) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x, 25, gameObject.transform.position.z);
			AudioSource.PlayClipAtPoint (audioClipDoorOpen, this.transform.position);
		} else {
			AudioSource.PlayClipAtPoint (audioClipDoorClose, this.transform.position);
		}
	}
		
}
