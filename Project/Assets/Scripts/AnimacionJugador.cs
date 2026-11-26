using UnityEngine;

public class AnimacionJugador : MonoBehaviour
{
    [SerializeField] private Sprite reposo;
    [SerializeField] private Sprite caminar;
    [SerializeField] private float tiempoFotograma = 0.12f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private float temporizador;
    private bool alternar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        float velocidad = rb.linearVelocity.x;

        if (Mathf.Abs(velocidad) > 0.1f)
        {
            sr.flipX = velocidad > 0;

            temporizador += Time.deltaTime;

            if (temporizador >= tiempoFotograma)
            {
                alternar = !alternar;
                temporizador = 0f;
            }

            sr.sprite = alternar ? caminar : reposo;
        }
        else
        {
            sr.sprite = reposo;
            temporizador = 0f;
            alternar = false;
        }
    }
}