using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

    [Header("Pantallas")]
    [SerializeField] private GameObject pantalla_principal;
    [SerializeField] private GameObject pantalla_seleccion_personaje;

    // Este objeto permite generar en la escena "Nivel 1" al personaje seleccionado desde la escena de Menú Principal
    [Space]
    [Header("Cargador de Personaje")]
    [SerializeField] private GameObject cargador;

    private SailorScout sailor_scout;

    void Start() {
        // Se asegura que la pantalla principal esté activa al comenzar el juego
        pantalla_principal.SetActive(true);
        pantalla_seleccion_personaje.SetActive(false);
    }

    // Al presionar el botón "Jugar", abre el menú para seleccionar un personaje jugable
    public void activarMenuSeleccionPersonaje() {
        pantalla_principal.SetActive(false);
        pantalla_seleccion_personaje.SetActive(true);
    }

    // Permite al jugador volver al menú principal
    public void volverPantallaPrincipal() {
        pantalla_seleccion_personaje.SetActive(false);
        pantalla_principal.SetActive(true);
    }

    // Dependiendo el botón que se presione, es el personaje que se va a generar al momento de cargar el nivel
    public void seleccionarPersonaje(int personaje_id) {
        switch (personaje_id) {
            case 0:
                sailor_scout = SailorScout.sailor_moon;
                break;

            case 1:
                sailor_scout = SailorScout.sailor_mercury;
                break;

            case 2:
                sailor_scout = SailorScout.sailor_mars;
                break;

            case 3:
                sailor_scout = SailorScout.sailor_jupiter;
                break;

            case 4:
                sailor_scout = SailorScout.sailor_venus;
                break;

            default: break;
        }
    }

    // Carga la escena de acuerdo a su nombre
    public void cargarEscena(string nombre) {
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
