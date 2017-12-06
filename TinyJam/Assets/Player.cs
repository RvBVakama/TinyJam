﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D m_rb;


    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // stop exponential velocity
        m_rb.velocity = Vector2.zero;
        
        // constantly flying to the right
        m_rb.AddForce(new Vector2(2.0f, 0.0f), ForceMode2D.Impulse);

        // if you hold space you fall
        if (Input.GetKey(KeyCode.Space))
            m_rb.AddForce(new Vector2(0.0f, -100.0f), ForceMode2D.Force);
    }
}
