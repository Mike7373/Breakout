using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private int _speed;
    private Rigidbody _ball;
    //private SphereCollider _ballCollider;
    private Vector3 _lastPos;
    
    public void Start()
    {
        _ball = GetComponent<Rigidbody>();
        //_ballCollider = GetComponent<SphereCollider>();
        SetVelocity(new Vector3(0,0,-_speed));
    }

    private void OnCollisionEnter(Collision collision)
    {
        var hitNormal = collision.contacts[0].normal;
        _ball.velocity = Vector3.Reflect(_ball.velocity, hitNormal);
    }

    public void SetVelocity(Vector3 velocity)
    {
        _ball.velocity = velocity;
    }
    
}
