using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private int _speed;
    private Rigidbody _ball;
    private Vector3 _lastPos;

    public void Start()
    {
        _ball = GetComponent<Rigidbody>();
        _lastPos = new Vector3(0, 0, -100);
        _ball.transform.position = new Vector3(0, 0, 0);
    }

    public void Update()
    {
        _ball.transform.position = _ball.transform.position + _lastPos * _speed * Time.deltaTime;
        _lastPos= new Vector3(_ball.transform.position.x, 0, _ball.transform.position.z);
    }
}
