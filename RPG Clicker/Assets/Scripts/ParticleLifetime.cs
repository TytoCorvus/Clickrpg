using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLifetime : MonoBehaviour {

	private float lifetime;
	private ParticleSystem particles;

	// Use this for initialization
	void Start () {
		particles = gameObject.GetComponent<ParticleSystem> ();
		particles.Play ();
		lifetime = particles.main.duration;
		Destroy (gameObject, lifetime + 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
