using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEventManager{

    private List<IAttackEventListener> listeners;

    public AttackEventManager(){
        listeners = new List<IAttackEventListener>();
    }

    public void AddListener(IListener l){
        if(l is IAttackEventListener){
            listeners.Add((IAttackEventListener)l);
        }
    }

    public void NewEvent(AttackEvent ae){
        for(int i = 0; i < listeners.Count; i++){
            listeners[i].ReceiveAttackEvent(ae);
        }
    	ae.pass = 1;
    	for(int i = 0; i < listeners.Count; i++){
            listeners[i].ReceiveAttackEvent(ae);
        }
    }

}
