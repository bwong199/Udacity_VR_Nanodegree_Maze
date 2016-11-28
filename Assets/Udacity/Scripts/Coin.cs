using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject gameObject; 



    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (this.gameObject);
		GetComponent<AudioSource> ().enabled = true;
		GetComponent<AudioSource> ().Play ();
    }

//	void OnTriggerEnter(Collider other)
//     {
//		
//     	if(other.gameObject.name == "Main Camera"){
//			print ("On Trigger Enter: Coin Contact");
//
//			
//			Destroy (this.gameObject);
//
//
//     	}
//     }

	void Update(){


	}

	void OnMouseDown ()
	{
		print ("clicked");
		OnCoinClicked ();
	}

}
