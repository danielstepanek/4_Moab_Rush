using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour
{
    int score;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
		scoreText = gameObject.GetComponent<Text>();
        scoreText.text = score.ToString();

    }

    // Update is called once per frame
    public void ScoreHit(int scorePerKill)
	{
        score = score + scorePerKill;
        scoreText.text = score.ToString();
	}
}
