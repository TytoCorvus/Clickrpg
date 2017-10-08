using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Ally : MonoBehaviour {

    private Ability[] abilities = new Ability[3];
    private List<Enemy> targets = new List<Enemy>();


    public static double defaultHP = 100;
    public


    //The following methods add an enemy or enemies to the List of targets AFTER clearing them
    public void SetTarget(Enemy enemy){
        targets.clear();
        targets.Add(enemy);
    }

    public void SetTarget(Enemy[] enemies){
        targets.clear();
        for(int i = 0; i < enemies.length; i++){
            targets.Add(enemies[i]);
        }
    }

    public Ability GetAbility(int num){
        return abilities[num];
    }


    abstract public void Attack();
    abstract public void Attack(Enemy e);
    abstract public void TakeDamage(double dmg);

}
