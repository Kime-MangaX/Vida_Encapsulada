using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth = 100;

    private int maxHealth = 100;

    public void TakeDamage(int AmountDamage)
    {
        currentHealth -= AmountDamage;

        if (currentHealth < 0)
        {
            currentHealth = 0;
            Debug.Log("MORISTE");
        }

        Debug.Log("Salud restante" + currentHealth);


    }

    public void Heal(int AmountHeal)
    {
        currentHealth += AmountHeal;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("Sanando. Salud acatual" + currentHealth);
    }

}
