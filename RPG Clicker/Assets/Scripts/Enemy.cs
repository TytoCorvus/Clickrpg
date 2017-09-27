using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour {

	private static double defaultHP;
	private static float defaultTimeBetweenAttacks;

	[SerializeField] private double maxHP;
	[SerializeField] public double currentHP { get; set; }
	private float timeBetweenAttacks;
	private float timeSinceLastAttack;
	private bool readyToAttack;


	// Use this for initialization
	void Start () {
		maxHP = defaultHP;
		currentHP = maxHP;
		timeBetweenAttacks = defaultTimeBetweenAttacks;
		timeSinceLastAttack = 0f;
		readyToAttack = false;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeSinceLastAttack += Time.deltaTime;
		if (timeSinceLastAttack >= timeBetweenAttacks) {
			Attack ();
		}

		if (currentHP < 0) {
			Destroy (gameObject, 2.0f);
		}
	}

	abstract public void Attack ();
	public void TakeDamage (double dmg){
		currentHP -= dmg;
	}

	public void OnMouseDown(){
		Debug.Log ("Damage Taken");
		TakeDamage (5.0);
	}

}
