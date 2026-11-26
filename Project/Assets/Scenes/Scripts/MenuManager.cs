using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string escenaJuego;

    public void Jugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(escenaJuego);
    }

    public void Salir()
    {
        Debug.Log("Saliendo del videojuego");
        Application.Quit();
    }
}