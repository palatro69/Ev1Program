using UnityEngine;
public class PlayerAudio : MonoBehaviour
{
    // Componente emisor que estará en el propio jugador
    public AudioSource sfxSource;
    // Archivos de audio (AudioClips) que arrastraremos desde el Inspector
    public AudioClip jumpClip;
    public AudioClip damageClip;
    public AudioClip shootClip;
    public void JumpSFX()
    {
        sfxSource.PlayOneShot(jumpClip, 0.7f);
    }

    public void ShotSFX()
    {
        sfxSource.PlayOneShot(shootClip, 0.3f);
    }

    public void DamSFX()
    {
        sfxSource.PlayOneShot(damageClip, 0.3f);
    }
}

