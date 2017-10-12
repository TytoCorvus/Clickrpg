using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : Character, IAttackEventListener {

    private Ability[] abilities = new Ability[3];
    private BarScript health;
    private BarScript attackTimer;
    private EnemyArea enemyArea;
    private AllyArea allyArea;
	private List<Character> targets;

    public static double defaultHP = 100;

    void Start(){
    	targets = new List<Character>();
    	enemyArea = GameObject.Find("EnemySpace").GetComponent<EnemyArea>();
    	allyArea = GameObject.Find("AllySpace").GetComponent<AllyArea>();
    	targets = enemyArea.GetEnemies();
    	if(targets == null){Debug.Log("targets in Ally instance is null");}
    	SetTarget(targets[0]);
    	this.GetEventManager().AddNewListener(this);
    	
    }

    //The following methods add an enemy or enemies to the List of targets AFTER clearing them
    override public void SetTarget(Character character){
        targets.Clear();
        targets.Add(character);
    }

    override public void SetTarget(Character[] character){
        targets.Clear();
        for(int i = 0; i < character.Length; i++){
            targets.Add(character[i]);
        }
    }

    override public void Attack(){
        AttackEvent newEvent = new AttackEvent(this, targets[0], (double)10);
        this.GetEventManager().AddNewEvent(newEvent);
    }

    override public void Attack(Character c){
        AttackEvent newEvent = new AttackEvent(this, c, (double)10);
        this.GetEventManager().AddNewEvent(newEvent);
    }

    override public void TakeDamage(double dmg){
        currentHitPoints -= dmg;
    }

    override public void Heal(double amt){
        currentHitPoints += amt;
    }

    public void ChangeHealth(double change){
        if(change == 0){}
        else if(change > 0){ Heal(change);}
        else{ TakeDamage(change);}
    }

    public Ability GetAbility(int num){
        return abilities[num];
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
