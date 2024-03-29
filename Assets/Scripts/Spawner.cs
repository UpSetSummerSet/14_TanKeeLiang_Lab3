﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnee;
    private float spawntime = 1;
    private float spawndelay=1;
    private int randomInt;
    float positionx;

    private AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobject", spawntime, spawndelay);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
       // spawntime = Random.Range(1, 3);
    }

    void spawnobject()
    {
        audioSource.Play();
        randomInt = Random.Range(0, spawnee.Length);
        positionx = Random.Range(8f,-8f);
        this.transform.position = new Vector3(positionx,transform.position.y , transform.position.z);
        Instantiate(spawnee[randomInt], transform.position, transform.rotation);
    }
}
