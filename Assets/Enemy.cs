using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] GameObject enemyDeathFX;
	[SerializeField] Transform parent;
	[SerializeField] int scorePerKill = 12;
	ScoreBoard scoreBoard;
    void Start()
	{
		scoreBoard = FindObjectOfType<ScoreBoard>();

		AddNonTriggerBoxCollider();
	}

	private void AddNonTriggerBoxCollider()
	{
		Collider collider = gameObject.AddComponent<BoxCollider>();
		collider.isTrigger = false;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
    void OnParticleCollision(GameObject other)
	{
		scoreBoard.ScoreHit(scorePerKill);
		GameObject fx = Instantiate(enemyDeathFX, transform.position, Quaternion.identity);
		fx.transform.parent = parent;
		Destroy(gameObject);
	}
}
