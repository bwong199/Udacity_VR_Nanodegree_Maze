using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyContact : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public static bool KEYFOUND; 
	public AudioClip audioClip;
	public GameObject gameObject;
	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
		Destroy (this.gameObject);
		KEYFOUND = true; 
		AudioSource.PlayClipAtPoint (audioClip, this.transform.position);


    }

}
