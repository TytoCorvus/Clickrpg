using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : Enemy {

	private static float defaultTimeBetweenAttacks = 4f;
	public BarScript health;
	public BarScript attackTimer;

	private float damage = 4;
	[SerializeField] private double maxHP = 100;


	// Use this for initialization
	void Start () {
	    maxHP = 100;
		currentHP = 100;
		this.SetTimeBetweenAttacks(defaultTimeBetweenAttacks);
		timeSinceLastAttack = 0f;
		
		health = transform.GetChild(0).GetChild(0).gameObject.GetComponent<BarScript>();
		attackTimer = transform.GetChild(0).GetChild(1).gameObject.GetComponent<BarScript>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeSinceLastAttack += Time.deltaTime;
		if (timeSinceLastAttack >= this.GetTimeBetweenAttacks()) {
			Attack ();
			timeSinceLastAttack = 0f;
		}

		if (currentHP <= 0) {
			Destroy (gameObject, 0f);
		}
		
		health.SetRatio((float)(currentHP/maxHP));
        attackTimer.SetRatio((float)(timeSinceLastAttack/defaultTimeBetweenAttacks));

	}
		
	override public void Attack(){
        attackTimer.SetRatio(0f);
	}

	override public void Attack(Character c){
        
    }

	public void OnMouseDown(){
		if(currentHP - damage >= 0){ currentHP -= damage;}
		else{ currentHP = 0; }


	}
}
