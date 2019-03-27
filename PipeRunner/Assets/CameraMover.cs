﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
      offset = this.transform.position - player.transform.position;     
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
