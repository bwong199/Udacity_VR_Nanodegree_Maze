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
			Destroy (GameObject.Find ("Door"));


     	}
     }
}
