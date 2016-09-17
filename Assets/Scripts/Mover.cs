﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    private Rigidbody rb;
   
    public float speed;

    void Start(){
        rb = GetComponent<Rigidbody>();
        rb.velocity = rb.transform.forward*speed;
    }
}
