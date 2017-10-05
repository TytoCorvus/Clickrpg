using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : Enemy {

	private static float defaultTimeBetweenAttacks = 4f;
	[SerializeField] public HealthBarScript health;
	private Transform healthBar;
	private float damage = 4;
	//[SerializeField] private double maxHP = 100;


	// Use this for initialization
	void Start () {
		currentHP = 100;
		maxHP = 100;
		this.setTimeBetweenAttacks(defaultTimeBetweenAttacks);
		timeSinceLastAttack = 0f;
		
		health = transform.GetChild(0).GetChild(0).gameObject.GetComponent<HealthBarScript>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeSinceLastAttack += Time.deltaTime;
		if (timeSinceLastAttack >= this.getTimeBetweenAttacks()) {
			Attack ();
			timeSinceLastAttack = 0f;
		}

		if (currentHP <= 0) {
			Destroy (gameObject, 0f);
		}
		
		health.SetHealthRatio((float)(currentHP/maxHP));
	}
		
	override public void Attack(){
	}

	public void OnMouseDown(){
		if(currentHP - damage >= 0){ currentHP -= damage;}
		else{ currentHP = 0; }
	}
}
