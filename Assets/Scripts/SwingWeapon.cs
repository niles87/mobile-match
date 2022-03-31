using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingWeapon : MonoBehaviour
{
    private Vector3 startingPos;
    public bool swing;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (swing)
        {
            Attack();
        }
    }

    public void Attack()
    {
        Debug.Log("Im running Attack now");
        Vector3 endPoint = new(-.75f, 0, 1.25f);
        Vector3 midSwing = new(1f, 0, 1f);

        float speed = 30f * Time.deltaTime;

        transform.Translate(Vector3.Lerp(startingPos, midSwing, .75f));
        
        transform.Translate(Vector3.Lerp(endPoint, midSwing, .75f));

        //transform.position = startingPos;

        swing = false;
    }
}
