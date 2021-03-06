﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }
    
}
