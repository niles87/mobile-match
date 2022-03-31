using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100f;
    public float shieldHealth = 100f;

    public void AbsorbDamage(float damage, string goName)
    {
        if (goName == "Shield")
        {
            shieldHealth -= damage;
        }
        else if (goName == "Body")
        {
            playerHealth -= damage;
        }
    }

    public void RepairShield(float value, bool bonus = false)
    {
        if (bonus)
        {
            shieldHealth = shieldHealth + value > 125 ? 125 : shieldHealth + value;
        }
        else
        {
            shieldHealth = shieldHealth + value > 100 ? 100 : shieldHealth + value;
        }
    }

    public void RegainHealth(float value, bool bonus = false)
    {
        if (bonus)
        {
            playerHealth = playerHealth + value > 125 ? 125 : playerHealth + value;
        }
        else
        {
            playerHealth = playerHealth + value > 100 ? 100 : playerHealth + value;
        }
    }
}
