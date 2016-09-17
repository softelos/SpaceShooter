﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary {
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    public float speed,tilt,fireRate;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotPawn;

    private Rigidbody rb;
    private float nextFire;

    void Start() {
        nextFire = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        if (Input.GetButton("Fire1") && (Time.time>nextFire)){
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotPawn.position, shotPawn.transform.rotation);
        }
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.velocity = (new Vector3(moveHorizontal, 0.0f, moveVertical))*speed;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax),0.0f,Mathf.Clamp(rb.position.z,boundary.zMin,boundary.zMax));
        rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x*-tilt);
    }
}
