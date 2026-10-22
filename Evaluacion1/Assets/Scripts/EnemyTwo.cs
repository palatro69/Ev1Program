using UnityEngine;
public class EnemyTwo : MonoBehaviour
{
    public float velocidad = 1.5f;
    [HideInInspector] public Transform jugador;
    [SerializeField] private Enemy enemyBase;
    private void Awake()
    {
        enemyBase = GetComponent<Enemy>();
    }
    private void Update()
    {
        if (jugador != null)
        {
            transform.position = Vector2.MoveTowards(transform.position,jugador.position,velocidad * Time.deltaTime);
        }
    }
    public void AsignarObjetivo(Transform nuevoObjetivo)
    {
        if (jugador == null)
        {
            jugador = nuevoObjetivo;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Daño al jugador " + enemyBase.damage);
        }
    }
}