using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class SceneChangeToNext: MonoBehaviour {  

    public void ChangeScene()
	{  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }  
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
    
}   