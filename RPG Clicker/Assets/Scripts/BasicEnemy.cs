﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy {

	private static float defaultTimeBetweenAttacks = 4f;
	[SerializeField] public GameObject healthBar;
	private GameObject canvas;
	//[SerializeField] private double maxHP = 100;


	// Use this for initialization
	void Start () {
		currentHP = maxHP;
		this.setTimeBetweenAttacks(defaultTimeBetweenAttacks);
		timeSinceLastAttack = 0f;
		readyToAttack = false;
		canvas = GameObject.Find("Canvas");
		healthBar = Instantiate(healthBar);
		healthBar.transform.parent = canvas.transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeSinceLastAttack += Time.deltaTime;
		if (timeSinceLastAttack >= this.getTimeBetweenAttacks()) {
			Attack ();
			timeSinceLastAttack = 0f;
		}

		if (currentHP < 0) {
			Destroy (gameObject, 2.0f);
		}
	}
		
	override public void Attack(){
		Debug.Log ("Attack event");
	}

	public void OnMouseDown(){

	}
}
