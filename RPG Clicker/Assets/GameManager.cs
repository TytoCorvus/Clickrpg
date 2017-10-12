using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameObject field;
	private GameObject enemySpace;
	private GameObject allySpace;
	private GameObject ui;
	private GameObject inputManager;

	// Use this for initialization
	void Start () {
		field = GameObject.Find ("Field");
		ui = GameObject.Find ("Canvas");
		inputManager = GameObject.Find ("InputManager");
		enemySpace = GameObject.Find ("EnemySpace");
		allySpace = GameObject.Find ("AllySpace");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
