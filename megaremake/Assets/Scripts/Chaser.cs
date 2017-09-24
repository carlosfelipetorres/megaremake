using UnityEngine;
using System.Collections;

////[RequireComponent(typeof(CharacterController))]

public class Chaser : MonoBehaviour
{

	public float speed = 20.0f;
	public float minDist = 1f;
	public Transform target;
	public GameObject destroyEffect;

	// Private Variables
	Renderer render;
	SphereCollider scollider;

	void Start ()
	{
		render = GetComponent<Renderer> ();
		scollider = GetComponent<SphereCollider> ();
		speed += Random.Range (0, 1.5f);
		// if no target specified, assume the player
		if (target == null)
		{
			if (GameObject.FindWithTag ("Player") != null)
			{
				target = GameObject.FindWithTag ("Player").GetComponent<Transform> ();
			}
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (target == null)
			return;

		// face the target
		transform.LookAt (target);

		//get the distance between the chaser and the target
		float distance = Vector3.Distance (transform.position, target.position);
		if (distance > minDist)
		{
			transform.position += transform.forward * speed * Time.deltaTime;	
		}
		else
		{
			Destroy (gameObject);
		}
	}

	// Set the target of the chaser
	public void SetTarget (Transform newTarget)
	{
		target = newTarget;
	}

	void OnMouseDown ()
	{
		Instantiate (destroyEffect, gameObject.transform);
		render.enabled = false;
		scollider.enabled = false;
		Invoke ("DestroyChaser", 1);
	}

	void DestroyChaser ()
	{
		Destroy (gameObject);
	}
}
