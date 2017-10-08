using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	[SerializeField] private GameObject clickParticles1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pz.z = 0;
		transform.position = pz;

		if (Input.GetMouseButtonDown (0)) {
			Instantiate (clickParticles1, pz, transform.rotation);
            Debug.Log("Hi, Dayne! I am a computer program!");
            Debug.Log("Also, hello Bryce! I am your humble servant.");
		}
	}
}
