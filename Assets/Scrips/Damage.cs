using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Damage : MonoBehaviour
{
    public Health targetHeath;
    public int damageValue = 10;
    public int healValue = 15;
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

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (targetHeath != null)
            {
                targetHeath.Heal(healValue);
                Debug.Log("¡Te estas curando!" + healValue);
            }

            else
            {
                Debug.LogWarning("Asigna a quien curar XD");
            }
        }
    }
}
