using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int Life;
    

    public void TakeDamage(int AmountDamage)
    {
        Life -= AmountDamage;
        Debug.Log("Vida restante" + Life);
    }

    public void Heal(int AmountHeal)
    {
        Life += AmountHeal;
        Debug.Log("Sanando" + Life);
    }
}
