using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

    /*** Variables ***/
    [SerializeField] private GameObject[] prefabs_plataformas;
    [SerializeField] private List<GameObject> lista_plataformas_activas = new List<GameObject>();

    // Posiciones para determinar cuando generar la siguiente plataforma aleatoria
    private float pos_inicio, pos_actual;


    /*** Funciones ***/

    private void Start() {
        pos_inicio = 0;

        // Busca la plataforma inicial del nivel, y la agrega a la lista
        GameObject plataforma_inicial = GameObject.Find("Plataforma 1");

        // Si por alguna razón la plataforma inicial se agregó previamente, verifica que no se repita en la lista
        if (lista_plataformas_activas.Contains(plataforma_inicial) == false) {
            lista_plataformas_activas.Add(plataforma_inicial);
        }
    }

    void Update() {
        generarPlataformaAleatoria();
    }

    private void generarPlataformaAleatoria() {
        // Determina la posición global actual del generador de plataformas
        pos_actual = transform.position.x;

        // Si la diferencia desde que se generó la última plataforma es igual a 40, se genera la siguiente plataforma aleatoria
        // Nota: cada plataforma debe tener una longitud de 40 unidades métricas !!
        if ((pos_actual - pos_inicio) >= 40f) {

            // Procura colocar al generador sobre el eje X, ignorando la altura actual del jugador
            transform.position = new Vector3(transform.position.x, 0f, 0f);

            // Genera un índice aleatorio
            int indice_aleatorio = Random.Range(0, prefabs_plataformas.Length);

            // Crea un nuevo objeto de plataforma a partir del índice aleatorio
            GameObject nueva_plataforma = Instantiate(prefabs_plataformas[indice_aleatorio], transform.position, Quaternion.identity);

            // Agrega la nueva plataforma a la lista de plataformas activas
            lista_plataformas_activas.Add(nueva_plataforma);

            // Si la cantidad de plataformas es mayor a 3, elimina la más antigua
            if (lista_plataformas_activas.Count >= 3) {
                Destroy(lista_plataformas_activas[0]);
                lista_plataformas_activas.RemoveAt(0);
            }

            // Configura el nuevo punto para la última plataforma generada
            pos_inicio = pos_actual;
        }
    }
}
