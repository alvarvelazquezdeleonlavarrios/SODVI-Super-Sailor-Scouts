using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinDeJuego : MonoBehaviour {

    private void Start() {
        GameObject puntuacion_final = GameObject.Find("Puntuacion Final");
        print("Puntuacion: " + puntuacion_final.transform.position.x);
        print("Coleccionables: " + puntuacion_final.transform.position.y);
    }

    public void menuPrincipal() {
        // Carga la escena del menú prinicpal
        SceneManager.LoadScene("Menu Principal");
    }

    public void salir() {
        Application.Quit();
    }

}
