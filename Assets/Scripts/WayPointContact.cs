using UnityEngine;
using System.Collections;

public class WayPointContact : MonoBehaviour
{

	bool keyFound = false;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision col)
	{

//		if (col.collider.gameObject.transform.childCount > 1) {
//			if (col.collider.gameObject.transform.Find ("Key").name == "Key") {
//				print ("key found");
//				keyFound = true;
//				Destroy (GameObject.Find ("Door"));
//
//				GetComponent<AudioSource>().Play();
//				print (keyFound);
//			}
//		}

		

        
	}

	void OnTriggerEnter (Collider other)
	{
/*ßß		print (other.name);*/
		// Destroy(other.gameObject);
	}


}
