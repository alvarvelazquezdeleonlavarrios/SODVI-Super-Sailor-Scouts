using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour {

    [Header("Atributos Generales")]
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float fuerza_salto = 5f;
    [SerializeField] private bool en_suelo = false;
    private float incremento_velocidad = 0.00001f;

    [Space]
    [Header("Referencias Externas")]
    [SerializeField] private Camera camara;
    [SerializeField] private GameObject fondo_escenario;

    // Referencias internas
    private Rigidbody2D rb;
    private Animator animator;


    /*** Funciones ***/

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        fondo_escenario = GameObject.Find("Fondo");
    }

    void Update() {
        mover();
        saltar();

        // Procura que el fondo de el escenario se mueva junto con la cámara, pero
        // de tal forma que no se mueva cuando el jugador salte
        fondo_escenario.transform.position = new Vector3(camara.transform.position.x, 3.6f, 0f);

        // Si por alguna razón el jugador se cae al vacío, pierde la partida automáticamente
        if (transform.position.y <= -9.0f) {
            Destroy(gameObject);
            SceneManager.LoadScene("Fin del Juego");
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        // Detecta si el jugador está tocando una plataforma
        if (collision.gameObject.tag == "Suelo") {
            en_suelo = true;
        }

        // Detecta si el jugador tocó a un enemigo
        if (collision.gameObject.tag == "Enemigo") {
            Destroy(gameObject);
            SceneManager.LoadScene("Fin del Juego");
        }
    }

    // Permite al jugador moverse constantemente a la derecha
    private void mover() {
        velocidad += incremento_velocidad;
        transform.position += transform.right * Time.deltaTime * velocidad;
        animator.SetTrigger("Caminar");
    }

    // Permite al jugador saltar al presionar la tecla Space y si está en el suelo
    private void saltar() {
        if (Input.GetKeyDown(KeyCode.Space) && en_suelo == true) {
            rb.AddForce(Vector2.up * fuerza_salto, ForceMode2D.Impulse);
            en_suelo = false;
            animator.SetTrigger("Saltar");
        }
    }
}
