using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Rigidbody rb;

    public float radius = 5f;
    public float force = 25f;

    public bool stopMovingForward = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerNearBy())
        {
            float rotationSpeed = 90f * Time.deltaTime;

            Vector3 positionDiff = _player.position - transform.position;

            Quaternion rotation = Quaternion.LookRotation(positionDiff, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed);
        }
    }

    private void FixedUpdate()
    {
        if (IsPlayerNearBy() && !stopMovingForward)
        {
            rb.AddForce(transform.forward.normalized * force);
        }
    }

    bool IsPlayerNearBy()
    {
        if (Vector3.Distance(transform.position, _player.position) < radius)
        {
            return true;
        }
        return false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            stopMovingForward = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            stopMovingForward = false;
        }
    }
}
