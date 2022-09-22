using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody _rb;
    private float _horizontalMove;
    private Vector3 tilt;


    [SerializeField] private float _moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        tilt = Input.acceleration;
        _horizontalMove = tilt.x * _moveSpeed;
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_horizontalMove, 0, 0);
    }
}
