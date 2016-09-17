using UnityEngine;
using System.Collections;

public class DestroyedByContact : MonoBehaviour {
    public GameObject explosion;
   
    void OnTriggerEnter(Collider other) {
        if (other.tag=="Shot"){
            Transform explosionLocation;
            explosionLocation = gameObject.transform;
            Instantiate(explosion, explosionLocation.position, explosionLocation.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
