using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Character : MonoBehaviour {

    private MasterEventManager eventManager;
    //protected List<Character> targets;

    public double maxHitPoints;
    public double currentHitPoints;

    public float timeBetweenActions;
    public float timeSinceLastAction;


    public Character(){
    	//targets = new List<Character>();
    }

    public MasterEventManager GetEventManager(){
        return eventManager;
    }



    abstract public void SetTarget(Character c);
    abstract public void SetTarget(Character[] c);

    abstract public void Attack();
    abstract public void Attack(Character c);

    virtual public void TakeDamage(double dmg){
        currentHitPoints -= dmg;
    }
    virtual public void Heal(double amount){
        currentHitPoints += amount;
    }
    virtual public void ChangeHealth(double amount){
        if(amount == 0){}
        else if(amount < 0){ TakeDamage(-1 * amount);}
        else{Heal(amount);}
    }

}
