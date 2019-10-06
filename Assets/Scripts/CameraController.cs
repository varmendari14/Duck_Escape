﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Use late update for follow cameras
    // Allows u to kno the player has for sure already moved
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

