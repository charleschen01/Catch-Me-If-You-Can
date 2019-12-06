using UnityEngine;
 
public class Player1 : MonoBehaviour
{
    public float _speed = 200f;

    public Vector3 _velocity = Vector3.forward;
    public float _deltaAngle = 3f;
 
    void Update(){
        // if(Input.GetKeyDown(KeyCode.RightArrow)){
        //     _velocity = Quaternion.Euler(0, 0, _deltaAngle) * _velocity;
        // }
        // if(Input.GetKeyDown(KeyCode.LeftArrow)){
        //     _velocity = Quaternion.Euler(0, 0, -_deltaAngle) * _velocity;
        // }
        // if(Input.GetKeyDown(KeyCode.UpArrow)){
        //     transform.position += _velocity * Time.deltaTime;
        // }
        // if(Input.GetKeyDown(KeyCode.DownArrow)){
        //     transform.position -= _velocity * Time.deltaTime;
        // }
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.position += _speed * _velocity * Time.deltaTime;
        }
    }
}
