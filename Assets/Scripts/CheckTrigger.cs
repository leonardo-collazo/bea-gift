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
            Debug.Log("Add Score");
            collision.gameObject.SetActive(false);
            // Destroy(collision.gameObject, 0.02f);
        }
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Game Over
            Debug.Log("Game Over!");
            Destroy(gameObject, 0.02f);
        }
    }
}
