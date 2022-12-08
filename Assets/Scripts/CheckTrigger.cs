using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            // Add score
            FindObjectOfType<AudioManager>().Play("Food");
            GameManager.Instance.AddScore();
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Game Over
            FindObjectOfType<AudioManager>().Play("GameOver");
            GameManager.Instance.GameOver();
            Destroy(this.gameObject, 0.02f);
        }
    }
}
