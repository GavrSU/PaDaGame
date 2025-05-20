using UnityEngine;

public class EngineSoundController : MonoBehaviour
{
    public AudioClip engineClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = engineClip;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = 0.7f;

        audioSource.Play(); // Начинаем воспроизведение
    }
}