﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Quit()
    {
        Application.Quit();

    }

    public void NextScene()
	{
		SceneManager.LoadScene("Game");
	}
}