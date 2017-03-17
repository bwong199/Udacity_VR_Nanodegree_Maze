using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	private bool keyFound; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
     {
     	if(other.gameObject.name == "Main Camera"){
			print ("On Trigger Enter");
			keyFound = true; 

			GetComponent<AudioSource>().Play();

			if(keyFound == true){
				GameObject doorObject = GameObject.Find ("Door");
				Door doorScript =  doorObject.GetComponent <Door>();
				doorScript.locked = false;
			}

     	}
     }
}
