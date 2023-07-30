using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuFinDeJuego : MonoBehaviour {

    [SerializeField] private Text puntuacion_total;
    [SerializeField] private Text coleccionables_total;

    private AudioSource audio_source;

    private void Start() {
        GameObject puntuacion_final = GameObject.Find("Puntuacion Final");
        puntuacion_total.text = "Puntuacion: " + puntuacion_final.transform.position.x.ToString();
        coleccionables_total.text = "Coleccionables: " + puntuacion_final.transform.position.y.ToString();

        audio_source = GetComponent<AudioSource>();
    }

    public void menuPrincipal() {
        audio_source.Play();

        // Carga la escena del menú prinicpal
        SceneManager.LoadScene("Menu Principal");
    }

    public void salir() {
        audio_source.Play();
        Application.Quit();
    }

}
