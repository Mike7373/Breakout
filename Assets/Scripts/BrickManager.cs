using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    private Rigidbody _brick;
    // Start is called before the first frame update
    void Start()
    {
        _brick = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        _brick.GameObject().SetActive(false);
    }
}
