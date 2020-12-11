using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
	Scene scene;
	// Start is called before the first frame update
	private void Awake()
	{
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPlayers > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
        
	}
	void Start()
    {
		if (scene.buildIndex == 0)
		{
			Invoke("StartGame", 2f);
		}
		else
		{
			return;
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
	{
		SceneManager.LoadScene(0);
	}
}
