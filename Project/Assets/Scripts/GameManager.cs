using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia { get; private set; }

    [SerializeField] private TMP_Text textoPuntaje;

    private int puntaje;

    private void Awake()
    {
        Instancia = this;
        ActualizarTexto();
    }

    public void SumarPuntos(int cantidad)
    {
        puntaje += cantidad;
        ActualizarTexto();
    }

    private void ActualizarTexto()
    {
        if (textoPuntaje != null)
            textoPuntaje.text = "Puntaje: " + puntaje;
    }
}
