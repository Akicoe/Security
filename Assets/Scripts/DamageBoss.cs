using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBoss : MonoBehaviour
{
	 public int damage = 5;
	
    void OnTriggerEnter2D (Collider2D hitInfo)
	{
		BossHealth enemy = hitInfo.GetComponent<BossHealth>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}
	}
}
