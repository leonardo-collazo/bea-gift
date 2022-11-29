using UnityEngine;

[System.Serializable]
public class Sound 
{
    [SerializeField] private string name;
    [SerializeField] private AudioClip clip;

    [SerializeField] private bool loop;

	[Range(0f, 3f)]
	[SerializeField] private float volume;
	
	[Range(0.1f,3f)]
    [SerializeField] private float pitch;

	[HideInInspector]
    private AudioSource source;

    public string Name { get => name; set => name = value; }
    public AudioClip Clip { get => clip; set => clip = value; }
    public bool Loop { get => loop; set => loop = value; }
    public float Volume { get => volume; set => volume = value; }
    public float Pitch { get => pitch; set => pitch = value; }
    public AudioSource Source { get => source; set => source = value; }
}
