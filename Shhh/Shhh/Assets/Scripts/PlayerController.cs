﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector3 velocity;
    //Rigidbody myRigidbody;

    void Start () {
        //myRigidbody = GetComponent<Rigidbody>();
    }

    /*public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    void FixedUpdate()
    {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
    }*/
}
