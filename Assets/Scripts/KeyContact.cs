using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

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


			GetComponent<AudioSource>().Play();
			GameObject doorObject = GameObject.Find ("Door");
			Door doorScript =  doorObject.GetComponent <Door>();
			doorScript.locked = false;
     	}
     }
}
