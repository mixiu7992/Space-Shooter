using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public GameObject hazard;
	public Vector3 spawnValue;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while(true){
			for(int i = 0 ; i < hazardCount;i ++){
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValue.x, spawnValue.x), 0, spawnValue.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
