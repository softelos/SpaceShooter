using UnityEngine;
using System.Collections;

public class DestroyedByContact : MonoBehaviour {
    public GameObject meteorExplosion;
	public GameObject playerExplosion;
   
    void OnTriggerEnter(Collider other) {
		Transform explosionLocation;

		if (other.tag == "Boundary") {
			return;
		}
        explosionLocation = gameObject.transform;
        Instantiate(meteorExplosion, explosionLocation.position, explosionLocation.rotation);
		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
