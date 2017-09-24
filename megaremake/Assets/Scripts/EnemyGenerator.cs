using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

	public GameObject enemy;

	// Private variables
	int i = 0;
	float maxWidth;
	float maxHeigth;

	// Use this for initialization
	void Start ()
	{
		maxWidth = Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x;
		maxHeigth = Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y;

		Debug.Log ("maxWidht: " + maxWidth + " maxHeigth: " + maxHeigth);
	}
	
	// Update is called once per frame
	void Update ()
	{
		i++;
		if (i % 50 == 0)
		{
			float randSignX = Random.Range (-1, 2); // get -1 or +1
			float randSignY = Random.Range (-1, 2); // get -1 or +1
			float coordX = Random.Range (0, maxWidth + 1);
			int randX = Mathf.RoundToInt ((coordX + (maxWidth - coordX)) * randSignX);
			float coordY = Random.Range (0, maxHeigth + 1);
			int randY = Mathf.RoundToInt ((coordY + (maxHeigth - coordY)) * randSignY);
			Debug.Log ("coordX: " + coordX + " coordY: " + coordY);
			Debug.Log ("randX: " + randX + " randY: " + randY);
			GameObject enemyTmp = Instantiate (enemy, new Vector3 (randX, randY, 0), Quaternion.identity);
			Destroy (enemyTmp, 10);
		}
	}
}
