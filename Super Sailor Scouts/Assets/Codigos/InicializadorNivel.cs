using UnityEngine;

public class InicializadorNivel : MonoBehaviour {

    [Header("Prefabs Personajes Jugables")]
    [SerializeField] private GameObject prefab_sailor_moon;
    [SerializeField] private GameObject prefab_sailor_mercury;
    [SerializeField] private GameObject prefab_sailor_mars;
    [SerializeField] private GameObject prefab_sailor_jupiter;
    [SerializeField] private GameObject prefab_sailor_venus;

    void Start() {
        GameObject cargador = GameObject.Find("Cargador");

        // Genera al personaje especificado desde la escena de menú principal
        if (cargador != null) {
            switch (cargador.transform.position.x) {
                // Sailor Moon
                case 0:
                    Instantiate(prefab_sailor_moon, new Vector3(-14.5f, 3.6f, 0), Quaternion.identity);
                    break;

                // Sailor Mercury
                case 1:
                    Instantiate(prefab_sailor_mercury, new Vector3(-14.5f, 3.6f, 0), Quaternion.identity);
                    break;

                // Sailor Mars
                case 2:
                    Instantiate(prefab_sailor_mars, new Vector3(-14.5f, 3.6f, 0), Quaternion.identity);
                    break;

                // Sailor Jupiter
                case 3:
                    Instantiate(prefab_sailor_jupiter, new Vector3(-14.5f, 3.6f, 0), Quaternion.identity);
                    break;

                // Sailor Venus
                case 4:
                    Instantiate(prefab_sailor_venus, new Vector3(-14.5f, 3.6f, 0), Quaternion.identity);
                    break;

                default:
                    break;
            }
        }
    }

}
