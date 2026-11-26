using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private int valor = 10;

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (!otro.CompareTag("Player")) return;

        GameManager.Instancia.SumarPuntos(valor);
        Destroy(gameObject);
    }
}
