using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyArea : MonoBehaviour {

    private List<Ally> allies = new List<Ally>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<Ally> GetAllies(){
        return allies;
    }

    public void AddAlly(Ally a){
        allies.Add(a);
    }

    public void ClearAllies(){
        allies.Clear();
    }
}
