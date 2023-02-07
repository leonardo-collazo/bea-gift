using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;

    public static AudioManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            s.Source.loop = s.Loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.Name == name);

        if (s == null)
        {
            Debug.Log("Sorry sound with name not found");
        }
        else
        {
            s.Source.Play();
        }
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.Name == name);

        if (s == null)
        {
            Debug.Log("Sorry sound with name not found");
            return;
        }
        else
        {
            s.Source.Stop();
        }
    }

}
