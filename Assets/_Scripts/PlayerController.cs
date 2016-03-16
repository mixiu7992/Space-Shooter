using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundray{
	public float minX,maxX,minZ,maxZ;
}


public class PlayerController : MonoBehaviour {
	
	public float speed;
	public float tilt;
	public Boundray boundray;

	private float nextFire;
	public float fireRate;
	public GameObject shot;
	public Transform shotSqawn;

	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSqawn.position, shotSqawn.rotation);
		}
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		GetComponent<Rigidbody> ().velocity = movement * speed;

		GetComponent<Rigidbody> ().position = new Vector3 (
			Mathf.Clamp(GetComponent<Rigidbody>().position.x,boundray.minX,boundray.maxX),
			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z,boundray.minZ,boundray.maxZ)
		);

		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody> ().velocity.x * -tilt);
	}
}
