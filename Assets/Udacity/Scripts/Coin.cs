using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject gameObject; 
    public AudioClip audioClip;


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		
//		GetComponent<AudioSource> ().enabled = true;
//		GetComponent<AudioSource> ().Play ();
		AudioSource.PlayClipAtPoint (audioClip, this.transform.position);
		Destroy (this.gameObject);


    }


	void Update(){


	}

	void OnMouseDown ()
	{
		print ("clicked");
		OnCoinClicked ();
	}

}
