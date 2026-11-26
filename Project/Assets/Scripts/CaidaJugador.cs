using UnityEngine;
using UnityEngine.SceneManagement;

public class CaidaJugador : MonoBehaviour
{
    [SerializeField] private float limiteCaida = -10f;

    private void Update()
    {
        if (transform.position.y < limiteCaida)
        {
            Time.timeScale = 1f;

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }
}