using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpsOverObstacle : MonoBehaviour {
	
	Rigidbody2D rb;

	void OnTriggerEnter2D (Collider2D col)
	{
		switch (col.tag) {

		case "SteelWall(1)":
			rb.AddForce (Vector2.up * 400f);
			break;

		case "SteelWall":
			rb.AddForce (Vector2.up * 450f);
			break;
		}	
	}

}