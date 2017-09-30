using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour {

	private List<GameObject> enemies;

	// TODO
	//private List<Missiles> missiles;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addEnemy(GameObject enemy, float distanceFromLeft, float distanceFromBottom){
		enemies.Add (enemy);
		enemy.transform.position = new Vector3 (transform.position.x + distanceFromLeft, transform.position.y + distanceFromBottom, transform.position.z);
	}

	public bool enemiesLeft(){
		if(enemies.
	}

}
