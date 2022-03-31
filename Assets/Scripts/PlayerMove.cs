using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float force = 50f;

    private Vector3 moveVector;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

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

    private void MovePlayer(Vector3 vector)
    {
        rb.AddForce(force * vector);
    }
}
