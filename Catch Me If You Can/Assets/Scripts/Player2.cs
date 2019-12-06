using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float thrust = 15.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce( Vector3.right * thrust );
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce( Vector3.left * thrust );
        }
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce( Vector3.forward * thrust );
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce( Vector3.back * thrust);
        }
        
    }

    public void goBackOrigin()
    {
        transform.position = new Vector3(9f,0.5f,9f);
    }
}
