using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterEventManager : MonoBehaviour {

    private AttackEventManager attackEventManager = new AttackEventManager();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddNewEvent(Event e){
        if(e is AttackEvent){
            Debug.Log("Attack Event Received");
            attackEventManager.NewEvent((AttackEvent)e);
        }
    }
}
