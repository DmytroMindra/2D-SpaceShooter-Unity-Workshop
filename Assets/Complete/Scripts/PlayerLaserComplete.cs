using UnityEngine;
using System.Collections;

public class PlayerLaserComplete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var speed = 7;
		var dy = speed * Time.deltaTime;
		transform.Translate (0, dy, 0);

		if (transform.position.y > 20) 
		{
			Destroy(this.gameObject);
		}

	}
}
