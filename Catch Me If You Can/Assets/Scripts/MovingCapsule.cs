using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCapsule : MonoBehaviour
{
    // Start is called before the first frame update

    [Range(0f, 10f)]
    public float _speed = 60f;

    public Vector3 direction = Vector3.right;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -8) {
            direction = Vector3.right;
        }
        else if (transform.position.x > 0) {
            direction = Vector3.left;
        }

        transform.position += _speed * direction * Time.deltaTime;

    }
}
