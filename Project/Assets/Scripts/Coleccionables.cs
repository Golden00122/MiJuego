using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>()
                .AgregarMoneda();

            Destroy(gameObject);
        }
    }
}