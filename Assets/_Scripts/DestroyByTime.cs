using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float destroyWait;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyWait);
	}
}
