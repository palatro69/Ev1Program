using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private float lifeTime = 3f; // segundos antes de autodestruirse
    void Start()
    {
        // Red de seguridad: se destruye solo si no impacta nada antes
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Buscamos el componente EnemyBase en el objeto golpeado y le restamos 1 de vida
            collision.gameObject.GetComponent<Enemy>().TakeDamage(1);
            Destroy(gameObject); // La bala se destruye tras impactar
        }
        else if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}