using UnityEngine;
using System.Collections;

public class ImpactParticleController : MonoBehaviour {

    public bool smashingTime = false;

    ParticleSystem impactSystem;

	// Use this for initialization
	void Start () {
        impactSystem = GetComponent<ParticleSystem>();
        impactSystem.Stop();
        StartCoroutine("Impact");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator Impact ()
    {
        while (enabled) {
            if (!smashingTime) {
                yield return null;
            } else {
                //print("Booyah!");
                impactSystem.Emit(1);

                smashingTime = false;
                yield return null;
            }
        }
    }
}
