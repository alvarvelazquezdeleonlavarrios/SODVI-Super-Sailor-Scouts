using UnityEngine;
using UnityEngine.UI;

public class InicializadorFinDeJuego : MonoBehaviour {

    [Header("Imagen Personaje")]
    [SerializeField] private Image imagen_personaje;

    [Space]
    [Header("Configuración de Imágenes")]
    [SerializeField] private Sprite sailor_moon_game_over;
    [SerializeField] private Sprite sailor_mercury_game_over;
    [SerializeField] private Sprite sailor_mars_game_over;
    [SerializeField] private Sprite sailor_jupiter_game_over;
    [SerializeField] private Sprite sailor_venus_game_over;

    void Start() {
        GameObject cargador = GameObject.Find("Cargador");

        switch (cargador.transform.position.x) {
            // Sailor Moon
            case 0:
                imagen_personaje.sprite = sailor_moon_game_over;
                break;

            // Sailor Mercury
            case 1:
                imagen_personaje.sprite = sailor_mercury_game_over;
                break;

            // Sailor Mars
            case 2:
                imagen_personaje.sprite = sailor_mars_game_over;
                break;

            // Sailor Jupiter
            case 3:
                imagen_personaje.sprite = sailor_jupiter_game_over;
                break;

            // Sailor Venus
            case 4:
                imagen_personaje.sprite = sailor_venus_game_over;
                break;

            default:
                break;
        }

        Destroy(cargador);
    }

}
