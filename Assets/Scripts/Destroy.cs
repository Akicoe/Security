using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   public float timeTilDestroy;

  
    void Update()
    {
        Destroy(gameObject, timeTilDestroy);
    }
}
