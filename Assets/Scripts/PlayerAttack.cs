using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject weaponPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack(InputValue input)
    {
        if (input.isPressed)
        {
            var obj = Instantiate(weaponPrefab, transform);

            obj.GetComponent<SwingWeapon>().player = transform;
        }
    }
}
