using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour {

	private List<GameObject> enemies;

	private GameObject basicEnemy1;
	private string path = "Enemies/Basic Enemy 1";
	// TODO
	//private List<Missiles> missiles;

	// Use this for initialization
	void Start () {
		
		enemies = new List<GameObject>();
		//basicEnemy1 = Instantiate (Resources.Load (path, typeof(GameObject))) as GameObject;
		basicEnemy1 = Instantiate(Resources.Load(path)) as GameObject;
		basicEnemy1.transform.parent = gameObject.transform;
		addEnemy (basicEnemy1, 1f, 1f);
		
		basicEnemy1 = Instantiate(Resources.Load(path)) as GameObject;
		basicEnemy1.transform.parent = gameObject.transform;
		addEnemy (basicEnemy1, 1f, -3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addEnemy(GameObject enemy, float distanceFromLeft, float distanceFromBottom){
		enemies.Add (enemy);
		enemy.transform.position = new Vector3 (transform.position.x + distanceFromLeft, transform.position.y + distanceFromBottom, transform.position.z);
	}

	public bool enemiesLeft(){
		if (enemies.Count > 0) { return true;}
		return false;
	}

}
