using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    /*** Variables ***/
    [Header("Textos en pantalla")]
    [SerializeField] private Text texto_puntaje;
    [SerializeField] private Text texto_coleccionables;

    [Space]
    [Header("Referencias Externas")]
    [SerializeField] private AudioClip sonido_coleccionable;

    private float puntuacion = 0f;       // Puntos basados en la distancia recorrida
    private int coleccionables = 0;      // Puntaje para los coleccionables
    private float pos_inicial_x = 0f;
    private AudioSource audio_source;


    /*** Funciones ***/

    void Start() {
        // Busca las referncias hacia los textos en pantalla
        texto_puntaje = GameObject.Find("Puntuacion").GetComponent<Text>();
        texto_coleccionables = GameObject.Find("Coleccionables").GetComponent<Text>();

        // Configura la posici�n inicial del jugador en el eje X
        pos_inicial_x = transform.position.x;

        // Muestra en pantalla la cantidad inicial de coleccionables
        texto_coleccionables.text = "Coleccionables: " + coleccionables;

        audio_source = GetComponent<AudioSource>();
    }

    void Update() {
        // Calcula el puntaje actual de acuerdo a la posici�n del jugador
        puntuacion = Mathf.Floor(transform.position.x - pos_inicial_x);
        texto_puntaje.text = "Puntuacion: " + (int)puntuacion;
    }

    void OnTriggerEnter2D(Collider2D objeto) {
        // Si el jugador choca con un coleccionable, aumenta la puntuaci�n de los coleccionables
        if (objeto.gameObject.tag == "Coleccionable") {
            coleccionables++;
            texto_coleccionables.text = "Coleccionables: " + coleccionables;
            Destroy(objeto.gameObject);

            audio_source.clip = sonido_coleccionable;
            audio_source.Play();
        }
    }

    public float getPuntuacion() {
        return puntuacion;
    }

    public int getColeccionables() {
        return coleccionables;
    }

}
