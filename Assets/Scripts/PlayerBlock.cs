using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBlock : MonoBehaviour
{
    public GameObject shield;

    private float shieldHealth;

    // Start is called before the first frame update
    void Start()
    {
        shieldHealth = GetComponent<PlayerHealth>().shieldHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBlock(InputValue input)
    {
        if (input.isPressed && shieldHealth > 0)
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }

    }
}
