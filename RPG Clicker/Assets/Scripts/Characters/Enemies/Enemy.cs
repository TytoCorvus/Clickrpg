using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : Character {

	public static double defaultHP = 100;
	public static float defaultTimeBetweenAttacks;

	[SerializeField] public double maxHP { get; set; }
	[SerializeField] public double currentHP { get; set; }
	private float timeBetweenAttacks;
	public float timeSinceLastAttack { get; set; }
	public bool readyToAttack;

    private Character target;
    private Character[] targets;


	// Use this for initialization
	void Start () {
		maxHitPoints = defaultHP;
		currentHitPoints = maxHitPoints;
		timeBetweenActions = defaultTimeBetweenAttacks;
		timeSinceLastAction = 0f;
		readyToAttack = false;

	}
	
	// Update is called once per frame
	virtual public void FixedUpdate () {
		timeSinceLastAttack += Time.deltaTime;
		if (timeSinceLastAction >= timeBetweenActions) {
			Attack ();
            timeSinceLastAction = 0f;
		}

		if (currentHP < 0) {
			Destroy (gameObject, 2.0f);
		}
	}

    override public void Attack(Character c){

    }

	override public void TakeDamage (double dmg){
		currentHitPoints -= dmg;
	}

	override public void Heal (double dmg){
        currentHitPoints += dmg;
    }

	public float GetTimeBetweenAttacks(){
		return timeBetweenAttacks;
	}

	public void SetTimeBetweenAttacks(float t){
		timeBetweenAttacks = t;
	}
	public void OnMouseDown(){
		TakeDamage (5.0);
	}

	override public void SetTarget(Character c){
        target = c;
	}

	override public void SetTarget(Character[] c){
        targets = c;
    }

	
}
