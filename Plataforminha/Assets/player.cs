﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

     public float Speed;
     public float Jump;
     private Rigidbody2D rig;
     private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);

        if (Input.GetMouseButtonDown(0) && !isJumping){
            rig.AddForce(Vector2.up * Jump, ForceMode2D.Impulse);  
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.layer == 8){
            isJumping = false;
        }
        
    }


}
