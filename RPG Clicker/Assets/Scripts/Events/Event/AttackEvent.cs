using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEvent : Event {

    public GameObject creator;
    public Character attacker;
    public Character target;
    public double damageDealt;

	public AttackEvent(Character a, Character t, double dmg){

        creator = a.gameObject;
        attacker = a;
        target = t;
        damageDealt = dmg;
    }

    public AttackEvent(Character c, Character a, Character t, double dmg){
        creator = c.gameObject;
        attacker = a;
        target = t;
        damageDealt = dmg;
    }


}
