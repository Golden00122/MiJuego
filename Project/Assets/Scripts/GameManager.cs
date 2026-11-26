using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia { get; private set; }

    [SerializeField] private TMP_Text textoPuntaje;
    private int puntaje;

    [Header("Interfaz")]
    [SerializeField] private TMP_Text textoMonedas;
    [SerializeField] private int totalMonedas = 5;
    [SerializeField] private GameObject panelVictoria;

    [Header("Audio")]
    [SerializeField] private AudioSource audioEfectos;
    [SerializeField] private AudioClip sonidoMoneda;
    [SerializeField] private AudioClip sonidoVictoria;

    private int monedasRecolectadas = 0;

    private void Awake()
    {
        Instancia = this;
    }

    private void Start()
    {
        Time.timeScale = 1f;

        if (panelVictoria != null)
            panelVictoria.SetActive(false);

        ActualizarContador();
        ActualizarPuntaje();
    }

    // Sistema de puntuacion de Matias
    public void SumarPuntos(int cantidad)
    {
        puntaje += cantidad;
        ActualizarPuntaje();
    }

    private void ActualizarPuntaje()
    {
        if (textoPuntaje != null)
            textoPuntaje.text = "Puntaje: " + puntaje;
    }

    // Sistema de recoleccion de monedas
    public void AgregarMoneda()
    {
        monedasRecolectadas++;

        if (audioEfectos != null && sonidoMoneda != null)
            audioEfectos.PlayOneShot(sonidoMoneda);

        ActualizarContador();

        if (monedasRecolectadas >= totalMonedas)
            GanarPartida();
    }

    private void ActualizarContador()
    {
        if (textoMonedas != null)
        {
            textoMonedas.text = "Monedas: "
                + monedasRecolectadas + "/" + totalMonedas;
        }
    }

    private void GanarPartida()
    {
        if (audioEfectos != null && sonidoVictoria != null)
            audioEfectos.PlayOneShot(sonidoVictoria);

        if (panelVictoria != null)
            panelVictoria.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ReiniciarPartida()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }
}