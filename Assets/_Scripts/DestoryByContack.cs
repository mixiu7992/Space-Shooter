using UnityEngine;
using System.Collections;

public class DestoryByContack : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Boundary"){
			return;
		}
		if(explosion != null){
			Instantiate (explosion, transform.position, transform.rotation);	
		}
		if(other.tag == "Player"){
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
		Debug.Log(other.name);
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
