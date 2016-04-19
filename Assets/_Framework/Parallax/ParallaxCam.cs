﻿using UnityEngine;
using System.Collections;

public class ParallaxCam : MonoBehaviour {

    public delegate void ParallaxCameraDelegate(float deltaMovement);

    public ParallaxCameraDelegate onCameraTranslate;
    private float oldPosition;


    void Start()
    {
        oldPosition = transform.position.x;
    }
    void Update()
    {
        if (transform.position.x != oldPosition)
        {
            if (onCameraTranslate != null)
            {
                float delta = oldPosition - transform.position.x;
                onCameraTranslate(delta);
            }
            oldPosition = transform.position.x;
        }
    }
}
