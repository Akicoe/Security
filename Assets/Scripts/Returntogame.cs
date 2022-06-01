using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class Returntogame: MonoBehaviour {  

	private int nextSceneToLoad;

    public void ReturnScene()
	{  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);  
    }  
	
    
}   