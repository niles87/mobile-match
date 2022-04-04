using UnityEngine;

public class SwingWeapon : MonoBehaviour
{
    public Transform player;
    public float force = 20f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(player.forward * force, ForceMode.Impulse);
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Vector3.Distance(transform.position, player.position) > 2)
            Destroy(gameObject);
    }
}
