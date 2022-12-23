using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    AudioSource audioSource;

    private void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void PlayMusic()
    {
        audioSource.Play();
    }
}
