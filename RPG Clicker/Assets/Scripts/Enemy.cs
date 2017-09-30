using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour {

	public static double defaultHP;
	public static float defaultTimeBetweenAttacks;

	[SerializeField] public double maxHP { get; set; }
	[SerializeField] public double currentHP { get; set; }
	private float timeBetweenAttacks;
	public float timeSinceLastAttack { get; set; }
	public bool readyToAttack;


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

	public float getTimeBetweenAttacks(){
		return timeBetweenAttacks;
	}

	public void setTimeBetweenAttacks(float t){
		timeBetweenAttacks = t;
	}
	public void OnMouseDown(){
		Debug.Log ("Damage Taken");
		TakeDamage (5.0);
	}

}
