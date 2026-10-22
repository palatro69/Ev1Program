using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    [Header("playersound")]
    [SerializeField] private PlayerAudio playeraudio;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);
        if (currentHealth <= 0)
        {
            Restart();
        }
    }
    public void Restart()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playeraudio = GetComponent<PlayerAudio>();
            playeraudio.DamSFX();
        }
    }
    
}
