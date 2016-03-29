using UnityEngine;
using System.Collections;

public class GridTile : MonoBehaviour {

	ParticleSystem emitter;
	public bool emit = false;

	ParticleSystem.Particle[] particles;
	int particlesAlive;

	// Use this for initialization
	void Start () {
		emitter = GetComponent<ParticleSystem>();
		emitter.Clear();
		emitter.Stop();

		particles = new ParticleSystem.Particle[emitter.maxParticles];
	}
	
	// Update is called once per frame
	void Update () {

		particlesAlive = emitter.GetParticles(particles);
		//Debug.Log("particles out: " + particlesAlive);

		if (emit && particlesAlive == 0){
			emitter.Clear();
			emitter.Emit(1);
		}
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.name == "Ball"){
			emit = (emit)? false : true;
		}
	}

	void OnTriggerExit2D (Collider2D col){
		if (col.name == "Ball"){
			emit = (emit)? false : true;
		}
	}
}
