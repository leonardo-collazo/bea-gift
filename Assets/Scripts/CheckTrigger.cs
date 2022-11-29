using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            // Add score
            FindObjectOfType<AudioManager>().Play("Coin");
            GameManager.Instance.AddScore();
            collision.gameObject.SetActive(false);
        }
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Game Over
            FindObjectOfType<AudioManager>().Play("GameOver");
            GameManager.Instance.GameOver();
            Destroy(this.gameObject, 0.02f);
        }
    }
}
