using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject cube;
	int i = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		if(i%100 == 0){
			Instantiate (cube, new Vector3 (Random.Range (-20, 20), 0, Random.Range (-20, 20)), Quaternion.identity);
		}
	}
}
