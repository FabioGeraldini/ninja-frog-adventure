using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int pointValue = 10;
    public AudioClip collectSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectSound != null)
                AudioSource.PlayClipAtPoint(collectSound, transform.position);
            GameManager.Instance.AddScore(pointValue);
            Destroy(gameObject);
        }
    }
}