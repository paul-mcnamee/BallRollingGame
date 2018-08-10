using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

	private int MAX_SCORE = 4;
	private int score;
	public Text winText; 
	public Text scoreText; 
	

	void Start(){
		score = 0;
		SetScoreText();
		winText.text = "";
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Pick Up"))
		{
			// Delete the pick up block
			Destroy(collision.collider.gameObject);

			// Add one to the score
			score++;
		}
	}

	void Update()
	{
		SetScoreText();
	}

	public void SetScoreText()
	{
		scoreText.text = "Score: " + score.ToString();
		if (score >= MAX_SCORE)
		{
			winText.text = "You WIN!";
			scoreText.text = "";
		}
	}
}
