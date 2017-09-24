using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public GameObject explosion;

	void OnCollisionEnter (Collision myCol)
	{
		if (myCol.gameObject.tag == "Enemy")
		{
			GameObject tmp = Instantiate (explosion, new Vector3 (0, 0, 0), Quaternion.identity);
			Destroy (tmp, 4);
		}
		Destroy (myCol.gameObject);
	}
}
