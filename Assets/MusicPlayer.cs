﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
	// Start is called before the first frame update
	private void Awake()
	{
        DontDestroyOnLoad(gameObject);
	}
	void Start()
    {
        Invoke("LoadScene",2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScene()
	{
		SceneManager.LoadScene(0);
	}
}