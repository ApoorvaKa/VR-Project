using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody _rb;

    void Start(){
        _rb = GetComponent<Rigidbody>();
    }

    // move forward and down constantly
    void FixedUpdate(){
        if(transform.position.y > 30){
            _rb.AddForce(0, -5, 0);
        }
        else if(transform.position.y < 0.5){
            _rb.AddForce(0, 5, 0);
        }
    }

    public void MoveUp(){
        _rb.AddForce(0, 15, 0);
    }

    public void MoveDown(){
        _rb.AddForce(0, -15, 0);
    }

    public void MoveRight(){
        _rb.AddForce(15, 0, 0);
    }

    public void MoveLeft(){
        _rb.AddForce(-15, 0, 0);
    }

    public void MoveForward(){
        _rb.AddForce(0, 0, 15);
    }

    public void MoveBackward(){
        _rb.AddForce(0, 0, -15);
    }

}
