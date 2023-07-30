using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    /*** Variables ***/
    [Header("Textos en pantalla")]
    [SerializeField] private Text texto_puntaje;
    [SerializeField] private Text texto_coleccionables;

    private float puntuacion = 0f;       // Puntos basados en la distancia recorrida
    private int coleccionables = 0;      // Puntaje para los coleccionables
    private float pos_inicial_x = 0f;


    /*** Funciones ***/

    void Start() {
        // Busca las referncias hacia los textos en pantalla
        texto_puntaje = GameObject.Find("Puntuacion").GetComponent<Text>();
        texto_coleccionables = GameObject.Find("Coleccionables").GetComponent<Text>();

        // Configura la posición inicial del jugador en el eje X
        pos_inicial_x = transform.position.x;

        // Muestra en pantalla la cantidad inicial de coleccionables
        texto_coleccionables.text = "Coleccionables: " + coleccionables;
    }

    void Update() {
        // Calcula el puntaje actual de acuerdo a la posición del jugador
        puntuacion = Mathf.Floor(transform.position.x - pos_inicial_x);
        texto_puntaje.text = "Puntuacion: " + (int)puntuacion;
    }

    void OnTriggerEnter2D(Collider2D objeto) {
        // Si el jugador choca con un coleccionable, aumenta la puntuación de los coleccionables
        if (objeto.gameObject.tag == "Coleccionable") {
            coleccionables++;
            texto_coleccionables.text = "Coleccionables: " + coleccionables;
            Destroy(objeto.gameObject);
        }
    }

    public float getPuntuacion() {
        return puntuacion;
    }

    public int getColeccionables() {
        return coleccionables;
    }

}
