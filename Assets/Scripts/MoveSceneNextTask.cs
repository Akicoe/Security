using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class MoveSceneNextTask: MonoBehaviour {  


    public void ChangeScene()
	{  
        SceneManager.LoadScene(11);  
    }  
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(11);
	}
    
}   