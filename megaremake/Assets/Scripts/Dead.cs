using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour {

	public GameObject explosion;

	void OnCollisionEnter(Collision myCol){
		if (myCol.gameObject.tag == "bad") {
			Instantiate (explosion, new Vector3 (0, 0, 0), Quaternion.identity);
		}
		Destroy (myCol.gameObject);
	}
}
