using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractedToObject : MonoBehaviour {

	public GameObject attractedTo;
	public float strengthOfAttraction = 0.01f;

	// Use this for initialization
	void Start () {
		//gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * new Vector3(Random.Range(800, 1700) ,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 direction = attractedTo.transform.position - transform.position;
		Vector3 direction = new Vector3(0,0,0) - transform.position;
		gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);

	}
}
