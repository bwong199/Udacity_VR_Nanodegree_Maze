using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public static bool KEYFOUND; 
	public AudioClip audioClip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnKeyClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		KEYFOUND = true; 
		AudioSource.PlayClipAtPoint (audioClip, this.transform.position);
//		GetComponent<AudioSource>().Play();


    }

	void OnTriggerEnter(Collider other)
     {
//     	if(other.gameObject.name == "Main Camera"){
//			print ("On Trigger Enter");
//			KEYFOUND = true; 
//
//			GetComponent<AudioSource>().Play();
//
//			if(keyFound == true){
//				GameObject doorObject = GameObject.Find ("Door");
//				Door doorScript =  doorObject.GetComponent <Door>();
//				doorScript.locked = false;
//			}
//
     	}
//     }
}
