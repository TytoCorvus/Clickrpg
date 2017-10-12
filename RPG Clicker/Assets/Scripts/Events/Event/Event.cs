using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Event{

	public GameObject creator;
	public List<Character> resolutionOrder;
	public int pass;
	
    public Event(){
		pass = 0;
		resolutionOrder = new List<Character>();
	}

	public Event(GameObject go){
        creator = go;
    }

}
