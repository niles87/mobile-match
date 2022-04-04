using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 100f;

    private DamageGenerator dg;

    // Start is called before the first frame update
    void Start()
    {
        dg = new();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            string name = other.name.Replace("(Clone)", "");
            float damage = dg.Damage(name);

            health -= damage;
        }
    }
}
