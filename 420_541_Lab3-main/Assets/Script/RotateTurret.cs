using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RotateTurret : MonoBehaviour
{
    // Start is called before the first frame update
    float rotationX;
    public MinMax minMax;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mY = Input.GetAxis("Mouse Y");

        rotationX += mY;
        rotationX = Mathf.Clamp(rotationX, minMax.minRotateX, minMax.maxRotateX);
        transform.rotation = Quaternion.Euler(-rotationX, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}

[Serializable]
public class MinMax {
    public float maxRotateX;
    public float minRotateX;
}