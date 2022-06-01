using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class SceneChanger: MonoBehaviour {  

	private int nextSceneToLoad;

    public void ChangeScene()
	{  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }  
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(nextSceneToLoad);
	}
    
}   