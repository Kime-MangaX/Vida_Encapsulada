using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Damage : MonoBehaviour
{
    public Health targetHeath;
    public int damageValue = 10;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (targetHeath != null)
            {
                targetHeath.TakeDamage(damageValue);

                Debug.Log("¡Ataque hecho! se resta: " + damageValue);
            }

            else
            {
                Debug.LogWarning("¡Cuidado! No asignaste el objetivo de salud");
            }
        }
    }
}
