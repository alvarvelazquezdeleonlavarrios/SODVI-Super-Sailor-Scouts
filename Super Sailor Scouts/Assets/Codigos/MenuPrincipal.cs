using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

    [Header("Pantallas")]
    [SerializeField] private GameObject pantalla_principal;
    [SerializeField] private GameObject pantalla_seleccion_personaje;
    [SerializeField] private Image flecha_seleccion;

    // Este objeto permite generar en la escena "Nivel 1" al personaje seleccionado desde la escena de Menú Principal
    [Space]
    [Header("Cargador de Personaje")]
    [SerializeField] private GameObject cargador;

    private SailorScout sailor_scout;
    private AudioSource audio_source;

    void Start() {
        // Se asegura que la pantalla principal esté activa al comenzar el juego
        pantalla_principal.SetActive(true);
        pantalla_seleccion_personaje.SetActive(false);

        audio_source = GetComponent<AudioSource>();
    }

    // Al presionar el botón "Jugar", abre el menú para seleccionar un personaje jugable
    public void activarMenuSeleccionPersonaje() {
        pantalla_principal.SetActive(false);
        pantalla_seleccion_personaje.SetActive(true);

        audio_source.Play();
    }

    // Permite al jugador volver al menú principal
    public void volverPantallaPrincipal() {
        pantalla_seleccion_personaje.SetActive(false);
        pantalla_principal.SetActive(true);

        audio_source.Play();
    }

    // Dependiendo el botón que se presione, es el personaje que se va a generar al momento de cargar el nivel
    public void seleccionarPersonaje(int personaje_id) {
        switch (personaje_id) {
            case 0:
                sailor_scout = SailorScout.sailor_moon;
                flecha_seleccion.rectTransform.localPosition = new Vector3(0, 270, 0);
                break;

            case 1:
                sailor_scout = SailorScout.sailor_mercury;
                flecha_seleccion.rectTransform.localPosition = new Vector3(-340, 270, 0);
                break;

            case 2:
                sailor_scout = SailorScout.sailor_mars;
                flecha_seleccion.rectTransform.localPosition = new Vector3(340, 270, 0);
                break;

            case 3:
                sailor_scout = SailorScout.sailor_jupiter;
                flecha_seleccion.rectTransform.localPosition = new Vector3(-680, 270, 0);
                break;

            case 4:
                sailor_scout = SailorScout.sailor_venus;
                flecha_seleccion.rectTransform.localPosition = new Vector3(680, 270, 0);
                break;

            default: break;
        }

        audio_source.Play();
    }

    // Carga la escena de acuerdo a su nombre
    public void cargarEscena(string nombre) {
        audio_source.Play();

        // Genera al personaje seleccionado
        switch (sailor_scout) {

            case SailorScout.sailor_moon:
                cargador.transform.position = new Vector3(0, 0, 0);
                DontDestroyOnLoad(cargador);
                break;

            case SailorScout.sailor_mercury:
                cargador.transform.position = new Vector3(1, 0, 0);
                DontDestroyOnLoad(cargador);
                break;

            case SailorScout.sailor_mars:
                cargador.transform.position = new Vector3(2, 0, 0);
                DontDestroyOnLoad(cargador);
                break;

            case SailorScout.sailor_jupiter:
                cargador.transform.position = new Vector3(3, 0, 0);
                DontDestroyOnLoad(cargador);
                break;

            case SailorScout.sailor_venus:
                cargador.transform.position = new Vector3(4, 0, 0);
                DontDestroyOnLoad(cargador);
                break;

            default:
                break;
        }

        // Carga la escena en cuestión
        SceneManager.LoadScene(nombre);
    }

    public void cerrarJuego() {
        audio_source.Play();
        Application.Quit();
    }
}

public enum SailorScout { 
    sailor_moon,
    sailor_mercury,
    sailor_mars,
    sailor_jupiter,
    sailor_venus
}
