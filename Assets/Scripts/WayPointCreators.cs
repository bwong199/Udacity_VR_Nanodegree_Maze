using UnityEngine;
using System.Collections;

public class WayPointCreators : MonoBehaviour {

	public GameObject prefab;
     public GameObject[] gos;

	// Use this for initialization
	void Start () {
		gos = new GameObject[30];
         for(int i = 0; i < gos.Length; i++)
         {
			GameObject clone = (GameObject)Instantiate(prefab, new Vector3(i + Random.Range (-30, 30), 0, i + Random.Range (-30, 30)), Quaternion.identity);
             gos[i] = clone;
         }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
