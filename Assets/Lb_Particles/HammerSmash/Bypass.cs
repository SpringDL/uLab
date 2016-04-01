using UnityEngine;
using System.Collections;

public class Bypass : MonoBehaviour {

    public bool smashingTime = false;
    bool smashing = false;

    public GameObject impactGO;
    ImpactParticleController impactSS;

	// Use this for initialization
	void Start () {
        impactSS = impactGO.GetComponent<ImpactParticleController>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (smashingTime) {
            smashingTime = false;
            StartCoroutine("SmashingTime");
            
        }
	}

    IEnumerator SmashingTime() {
        if (!smashing) {
            smashing = true;
            yield return new WaitForSeconds(0.1f);
            impactSS.smashingTime = true;
            smashing = false;
        }else {
            yield return null;
        }
    }
}
