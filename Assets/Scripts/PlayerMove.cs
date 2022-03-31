using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float force = 50f;

    private Vector3 moveVector;
    private Vector3 lookDirection = Vector3.one;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //RotatePlayer(lookDirection);
    }

    private void FixedUpdate()
    {
        MovePlayer(moveVector);
    }

    public void OnMove(InputValue input)
    {
        Vector2 pos = input.Get<Vector2>();

        moveVector = new(pos.x, 0, pos.y);
    }

    public void OnLook(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();

        lookDirection = new(0, dir.y, 0);
    }

    private void MovePlayer(Vector3 vector)
    {
        rb.AddForce(force * vector);
    }

    private void RotatePlayer(Vector3 stickDir)
    {
        float rotationSpeed = 90f * Time.deltaTime;

        Vector3 posDif = stickDir - transform.position;

        Quaternion rotation = Quaternion.LookRotation(posDif, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed);
    }
}
