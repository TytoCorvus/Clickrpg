using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	private static string scoreMessage = "Score: ";
	private int score = 0;
	private Text thisText;
	// Use this for initialization
	void Start () {
		thisText = gameObject.GetComponent<Text> ();
		thisText.text = scoreMessage + score;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		thisText.text = scoreMessage + score;
	}
		
	public void addToScore(int plus){
		score += plus;
	}

	public int getScore(){
		return score;
	}
}
