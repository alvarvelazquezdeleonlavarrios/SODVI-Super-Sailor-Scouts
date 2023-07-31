# Documentación de Jugador.cs
Componente principal de cada prefab de jugador.

## Variables Públicas
### 1. `velocidad` (`[SerializeField] private float velocidad = 5f`)
Representa la cantidad de movimiento hacia la derecha en el eje X del objeto Jugador.

### 2. `fuerza_salto` (`[SerializeField] private float fuerza_salto = 5f`)
Representa la cantidad de movimiento hacia arriba en el eje Y del objeto Jugador. Indica la fuerza con la que el jugador puede saltar.

### 3. `en_suelo` (`[SerializeField] private bool en_suelo = false`)
Indica si el jugador se encuentra tocando el suelo o no. Se utiliza para indicar si el jugador puede ejecutar la acción de salto.

### 4. `camara` (`[SerializeField] private Camera camara`)
Objeto de cámara que va siguiendo al jugador durante la partida. La cámara debe ser un objeto hijo del jugador.

### 5. `fondo_escenario` (`[SerializeField] private GameObjct fondo_escenario`)
Objeto que representa el cielo y montañas del nivel y que se va moviendo junto con el jugador. Este no debe ser hijo del objeto jugador.

### 6. `sonido_salto` (`[SerializeField] private AudioClip sonido_salto`)
Archivo de audio que reproduce el sonido de salto. Debe ser configurado desde la carpeta de Assets.

## Variables Privadas
### 1. `rb` (`private RigidBody2D rb`)
Componente de físicas que debe ser parte del objeto jugador pára permitir a este realizar la acción de salto, caer por gravedad e interactuar con el sistema de colisiones.

### 2. `animator` (`private Animator animator`)
Componente de animación que debe ser parte del objeto jugador y que se encarga de reproducir las animaciones de caminar y salto del jugador.

### 3. `audio_source` (`private AudioSource audio_source`)
Componnte de audio que debe ser parte del objeto jugador y que permite reproducir el sonido de salto coando el jugador salta, o cuando el jugador toca un objeto coleccionable.

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Configura los componentes privados del jugador y el fondo del nivel.

### 2. `void Update()`
Función de Unity que se va ejecutando cada fotograma del juego. Permite ejecutar las funciones de caminar y saltar, así como mover el fondo del escenario con rspecto a la posición del jugador, de tal manera que se quede fijo sobre el eje X, y también verifica que el jugador no se caiga a un vacío infinito.

### 3. `void OnCollisionEnter2D(Collision2D collision)`
Función de Unity que se encarga de detectar si el jugador colisionó con algún objeto físico. Determina si fue el suelo para que pueda saltar, o si fue un enemigo para generar un objeto llamado "Puntuación Final" (almacena la puntuación y número de coleccionables), y cargar la partida de Fin de Juego.

### 4. `void mover()`
Mueve constantemente hacia la derecha al jugador. Conforme transcurre el tiempo, va aumentando ligeramente la velocidad.

### 5. `void saltar()`
Permite al jugador saltar cuando este se encuentra en el suelo. Aplica una fuerza hacia el componente RigidBody2D del jugador. Reproduce el sonido de salto.

### 6. `void generarPuntuacionFinal()`
Función que se ejecuta cuando el jugador activa alguna condición para cargar la escena de Fin de Juego. Genera un nuevo objeto vacío en escena, guarda la puntuación y coleccionables del nivel, y lo carga en la escena de fin de juego.

## Usos y Consideraciones
1. Asignar esta script como componente del objeto jugador.
2. Verificar que se tenga asignada una cámara y un sonido de salto desde el Inspector. La cámara debe ser hijo del objeto que tenga esta script.
3. Cualquier instancia de este objeto debe generarse en una escena que contenga un fondo para que este pueda ser detectado desde la función Start.
4. El objeto jugador debe tener los siguientes componentes: RigidBody2D, CapsuleCollider2D.