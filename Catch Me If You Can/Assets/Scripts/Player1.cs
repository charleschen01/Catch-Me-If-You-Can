using UnityEngine;
public class Player1 : MonoBehaviour
{
    public float thrust = 10.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce( Vector3.right * thrust );
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce( Vector3.left * thrust );
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce( Vector3.forward * thrust );
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce( Vector3.back * thrust);
        }
    }
}

