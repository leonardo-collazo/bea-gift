using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            // Play the sound food
            FindObjectOfType<AudioManager>().Play("Food");

            // Add score
            GameManager.Instance.AddScore();
            
            // Change to next background if score is a multiple of 5
            GameManager.Instance.ChangeBackground();
            
            // Disable the food
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
