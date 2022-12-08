using UnityEngine;

public class InitialPosition : MonoBehaviour
{
    private Transform starterTransform;

    public Transform StarterTransform { get => starterTransform; }

    void Awake()
    {
        starterTransform = transform;
    }
}
