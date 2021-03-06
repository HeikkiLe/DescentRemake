﻿using UnityEngine;
using System.Collections;

public class MissileMove : MonoBehaviour
{
    private Vector3 direction;
<<<<<<< HEAD
    private float speed;
=======
    [SerializeField]
    private GameObject missilexplosion;
    private GameObject player;
    //Projectile's speed
    [SerializeField]
    private float speed = 1f;
>>>>>>> develop
    private float radius = 15.0f;
    private float power = 100.0f;
    // Use this for initialization

    void Start()
    {
        direction = this.transform.forward;
<<<<<<< HEAD
        speed = 30f;
=======
        player = GameObject.FindGameObjectWithTag("Player");
        this.GetComponent<Rigidbody>().velocity = player.GetComponent<Rigidbody>().velocity;
>>>>>>> develop
        GameObject.Destroy(this.gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(direction * speed);
    }

    void OnTriggerEnter(Collider col)
    {
        Vector3 explosionPos = this.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0f, ForceMode.Force);
        }
        Destroy(this.gameObject);
    }
}
