using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Event{

	public GameObject creator;

    public Event(){}

	public Event(GameObject go){
        creator = go;
    }

}
