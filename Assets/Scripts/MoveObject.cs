using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
