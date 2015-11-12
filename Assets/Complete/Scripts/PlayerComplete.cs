using UnityEngine;
using System.Collections;

public class PlayerComplete : MonoBehaviour {

	public GameObject laserPrefab;
	public Transform laserGun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	// Подробнее читайте на http://docs.unity3d.com/ru/current/Manual/ExecutionOrder.html
	void Update () {

		var horizontalInput = Input.GetAxis("Horizontal");
		var verticalInput = Input.GetAxis("Vertical");
		var speed = 5;
		var dx = speed * Time.deltaTime * horizontalInput;
		var dy = speed * Time.deltaTime * verticalInput;
		transform.Translate (dx, dy, 0);

		if (Input.GetButton ("Fire1")) 
		{
			Instantiate(laserPrefab,laserGun.position,Quaternion.identity);
		}

	}
}

// Шаг 1: 
/*
		var horizontalInput = Input.GetAxis("Horizontal");
		var speed = 5;
		var dx = speed * Time.deltaTime * horizontalInput;
		transform.Translate (dx, 0, 0);
*/

// Шаг 2: 
/*
		var horizontalInput = Input.GetAxis("Horizontal");
		var verticalInput = Input.GetAxis("Vertical");
		var speed = 5;
		var dx = speed * Time.deltaTime * horizontalInput;
		var dy = speed * Time.deltaTime * verticalInput;
		transform.Translate (dx, dy, 0);
 */