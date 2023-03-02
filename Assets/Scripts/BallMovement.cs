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
        SetVelocity(new Vector3(0,0,-1));
        //_lastPos = _ball.velocity;
    }

    public void Update()
    {
        //_ball.velocity = _lastPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var hitNormal = collision.contacts[0].normal;
        SetVelocity(Vector3.Reflect(_ball.velocity, hitNormal).normalized);
        //_lastPos = _ball.velocity;
    }

    public void SetVelocity(Vector3 dir)
    {
        _ball.velocity = dir * _speed;
    }
    
}
