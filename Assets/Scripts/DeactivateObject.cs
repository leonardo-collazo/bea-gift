using UnityEngine;

public class DeactivateObject : MonoBehaviour
{
    // Deactivates this gameobject if it triggers with a bound
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bound"))
        {
            gameObject.SetActive(false);
        }
    }
}
