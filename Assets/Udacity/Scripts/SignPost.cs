using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SignPost : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
//		if (Input.GetMouseButtonDown (0)) {
//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//           RaycastHit hit;
//         if (Physics.Raycast(ray, out hit)) {
//				print ("Clicked");
//          Debug.Log ("Name = " + hit.collider.name);
//          Debug.Log ("Tag = " + hit.collider.tag);
//          Debug.Log ("Hit Point = " + hit.point);
//          Debug.Log ("Object position = " + hit.collider.gameObject.transform.position);
//          Debug.Log ("--------------");
//         }
//       
//}
	}

	void OnTriggerEnter (Collider other)
	{
     	
//		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}

	public void ResetScene ()
	{
//		print ("I was clicked");     
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Key.KEYFOUND = false;
	}



}