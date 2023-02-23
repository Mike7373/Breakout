using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private Camera _camera;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move()
    {
        _rigidbody.transform.position = new Vector3(_camera.ScreenToWorldPoint(Input.mousePosition).x, 0, -7);
    }
}
