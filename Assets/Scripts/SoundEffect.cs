using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
	public AudioSource run;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void ScreamSound()
	{
		run.Play();
	}
}
