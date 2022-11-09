using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
