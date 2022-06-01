using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
	public GameObject gameOverScreen;
	private void Awake()
	{
		isGameOver = false;
	}
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
		{
			gameOverScreen.SetActive(true);
		}
    }
}
