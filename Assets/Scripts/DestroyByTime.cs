using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float lifeTime;

	void start(){
		Destroy (gameObject,lifeTime);
	}

}
