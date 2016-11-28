using UnityEngine;
using System.Collections;

public class VTWallsCreator : MonoBehaviour {

	public GameObject prefabV;
     public GameObject[] gosV;
	// Use this for initialization
	void Start () {
		gosV = new GameObject[5];
		for(int i = 0; i < gosV.Length; i++)
         {
			GameObject clone = (GameObject)Instantiate(prefabV, new Vector3(i + Random.Range (-40, 40), 0, i + Random.Range (-40, 40)), Quaternion.identity);
			clone.transform.transform.Rotate(0, 90, 0);
			gosV[i] = clone;
         }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
