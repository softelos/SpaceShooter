using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject asteroid;
	public int maxAsteroids;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawnAsteroids ());
	}
	
	IEnumerator spawnAsteroids(){
		yield return new WaitForSeconds (5);
		while (true) {
			for (int count = 0; count < Random.Range (1, maxAsteroids); count++) {
				Vector3 position = new Vector3 (Random.Range (-5.0f, 5.0f), 0, 15	);
				Quaternion rotation = new Quaternion ();
				Instantiate (asteroid, position, rotation);
			}
			yield return new WaitForSeconds (5);
		}
		yield return new WaitForSeconds (5);
	}
}
