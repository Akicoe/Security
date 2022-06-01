using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
   private float timeTilSpawn;
   public float startTimeTilSpawn;
   
   public GameObject laser1;
   public Transform whereToSpawn;

   
    private void Update()
    {
        if (timeTilSpawn <= 0)
		{
			Instantiate(laser1, whereToSpawn.position, whereToSpawn.rotation);
		
			timeTilSpawn = startTimeTilSpawn;
		}
		else
		{
			timeTilSpawn -= Time.deltaTime;
		}
    }
}
