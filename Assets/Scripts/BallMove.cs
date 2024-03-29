using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    Rigidbody ball;
    [SerializeField] private float powerImpulse = 80f;
    void Start()
    {
        //Debug.Log("LOG");
        //Debug.LogWarning("WARRNING");
        //Debug.LogError("ERROR");
        //Application.targetFrameRate = 5;
        ball = this.gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Debug.Log("LOG in UPDATE METHOD");
        //Debug.LogError("ERROR");
        if (Input.GetKeyDown(KeyCode.A))
        {
            ball.AddForce(-transform.right * powerImpulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ball.AddForce(transform.right * powerImpulse);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ball.AddForce(transform.forward * powerImpulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ball.AddForce(-transform.forward * powerImpulse);
        }
    }
    public void MoveUp()
    {
        //Debug.Log("UP");
        ball.AddForce(Vector3.forward * powerImpulse);
    }
    public void MoveDown()
    {
        //Debug.Log("DOWN");
        ball.AddForce(-Vector3.forward * powerImpulse);
    }
    public void MoveLeft()
    {
        //Debug.Log("LEFT");
        ball.AddForce(Vector3.left * powerImpulse);
    }
    public void MoveRight()
    {
        //Debug.Log("RIGHT");
        ball.AddForce(-Vector3.left * powerImpulse);
    }
}
