using UnityEngine;
using System.Collections;

public class HZWallsCreator : MonoBehaviour {


	public GameObject prefabH;
     public GameObject[] gosH;


	// Use this for initialization
	void Start () {
		gosH = new GameObject[5];
		for(int i = 0; i < gosH.Length; i++)
         {
			GameObject clone = (GameObject)Instantiate(prefabH, new Vector3(i + Random.Range (-40, 40), 0, i + Random.Range (-40, 40)), Quaternion.identity);
			gosH[i] = clone;
         }


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
