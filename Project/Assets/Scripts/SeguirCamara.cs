using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private Vector3 desfase = new Vector3(0f, 1f, -10f);
    [SerializeField] private float suavizado = 5f;

    private void LateUpdate()
    {
        if (objetivo == null) return;

        Vector3 destino = objetivo.position + desfase;
        transform.position = Vector3.Lerp(transform.position, destino, suavizado * Time.deltaTime);
    }
}
