using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : Enemy, IAttackEventListener {

	private static float defaultTimeBetweenAttacks = 4f;
	public BarScript health;
	public BarScript attackTimer;

	private float damage = 4;
	[SerializeField] private double maxHP = 100;
	
	private EnemyArea enemyArea;
    private AllyArea allyArea;


	// Use this for initialization
	void Start () {
	    maxHP = 100;
		currentHP = 100;
		this.SetTimeBetweenAttacks(defaultTimeBetweenAttacks);
		timeSinceLastAttack = 0f;
		
		health = transform.GetChild(0).GetChild(0).gameObject.GetComponent<BarScript>();
		attackTimer = transform.GetChild(0).GetChild(1).gameObject.GetComponent<BarScript>();
		
		enemyArea = GameObject.Find("EnemySpace").GetComponent<EnemyArea>();
    	allyArea = GameObject.Find("AllySpace").GetComponent<AllyArea>();
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
	
	public void ReceiveAttackEvent(AttackEvent ae){
		if(ae.pass == 0){
    		if(ae.attacker == this){
    			ae.damageDealt = 10;
    		}
    	}
    	if(ae.pass == 1){
    		if(ae.target == this){
    			TakeDamage(ae.damageDealt);
    		}
    	}
	}
}
