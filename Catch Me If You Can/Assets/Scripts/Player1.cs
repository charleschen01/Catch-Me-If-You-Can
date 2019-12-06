using UnityEngine;
public class Player1 : MonoBehaviour
{
    public float thrust = 20.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player2")
        {
            //call function hit in game logic
            GameLogic.Instance.Hit();
        }
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

    // goBackOrigin is called when we start another round to place the player at the original position
    public void goBackOrigin()
    {
        transform.position = new Vector3(-9f,0.5f,-9f);
    }
}

