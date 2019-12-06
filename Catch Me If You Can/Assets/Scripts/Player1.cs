using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float thrust = 5.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
           // Debug.Log("forward "+transform.forward+" right "+transform.right);
            rb.AddForce( Vector3.right * thrust );
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce( - Vector3.right * thrust );
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            //Debug.Log("forward "+transform.forward+" right "+transform.right);
            rb.AddForce( Vector3.forward * thrust );
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce( - Vector3.forward * thrust);
        }
        
    }
}

