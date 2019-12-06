using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBar : MonoBehaviour
{
    [Range(0f, 10f)]
    public float angle;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f,angle,0.0f,Space.Self);
    }
}
