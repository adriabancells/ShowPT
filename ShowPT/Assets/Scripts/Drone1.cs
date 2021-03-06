﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone1 : Enemy {

    public Transform player;
    public float shootingDistance = 20f;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            checkPlayerDistance();
            shotPoint.LookAt(player);
        }
        shoot();
    }

    public override void getHit()
    {
        --enemyHealth;
        Debug.Log(enemyHealth);
        //Execute properly Animation
        checkHealth();
    }

    private void checkPlayerDistance()
    {
        if (player != null && Vector3.Distance(player.position,transform.position) <= shootingDistance)
        {
            active = true;
        }
        else
        {
            active = false;
        }
    }
}
