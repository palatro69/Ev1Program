using UnityEngine;
public class EnemyDetector : MonoBehaviour
{
    private EnemyTwo persecutor;
    private void Awake()
    {
        // Obtiene la referencia del script en el objeto padre
        persecutor = GetComponentInParent<EnemyTwo>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            persecutor.AsignarObjetivo(collision.transform);
        }
    }
}
