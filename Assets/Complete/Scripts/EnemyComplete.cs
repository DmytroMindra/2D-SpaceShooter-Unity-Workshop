﻿using UnityEngine;
using System.Collections;

public class EnemyComplete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		//if (coll.gameObject.tag == "PlayerLaser") 
		{
			Destroy(gameObject);
		}

		
	}
	
}
