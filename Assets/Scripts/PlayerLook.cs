using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLook(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();

        RotatePlayer(dir);
    }

    private void RotatePlayer(Vector2 stickDir)
    {
        if (stickDir.magnitude > .1f)
        {
            float angle = Mathf.Atan2(stickDir.x, stickDir.y) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(0, angle, 0)), .5f);
        }
    }
}
