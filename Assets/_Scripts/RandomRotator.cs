using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
	
	public float maxRotation;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitCircle * maxRotation;
	}
}
