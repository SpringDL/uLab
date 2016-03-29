using UnityEngine;
using System.Collections;

public class BallPivot : MonoBehaviour {

	public float rotationSpeed = 500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, rotationSpeed * -Time.deltaTime);
	}
}
