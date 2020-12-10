using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisonHandler : MonoBehaviour
{
	[SerializeField] float loadLevelDelay = 1f;
    [SerializeField] GameObject deathFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }
	private void OnTriggerEnter(Collider other)
	{
        StartDeathSequence();
        deathFX.SetActive(true);
		Invoke(nameof(ReloadScene), loadLevelDelay);

	}
	// Update is called once per frame
	void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }
    private void ReloadScene()
	{
		SceneManager.LoadScene(0);

	}
}
