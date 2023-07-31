# Documentación de Puntaje.cs

## Variables Públicas
### 1. `texto_puntaje` (`[SerializeField] private Text texto_puntaje`)
Objeto de texto que muestra en pantalla el número de puntos.

### 2. `texto_coleccionables` (`[SerializeField] private Text texto_coleccionables`)
Objeto de texto que muestra en pantalla la cantidad de coleccionables.

### 3. `sonido_coleccionable` (`[SerializeField] private AudioClip sonido_coleccionable`)
Archivo de audio que reproduce el sonido de coleccionable recogido.

## Variables Privadas
### 1. `puntuacion` (`private float puntuacion = 0f`)
Determina la puntuación de la partida con respecto a la posición del jugador.

### 2. `coleccionables` (`private int coleccionables = 0`)
Determina la cantidad de coleccionables obtenidos durante la partida.

### 3. `pos_inicial_x` (`private float pos_inicial_x = 0f`)
Al inicio del juego, determina la posición inicial en X del jugador.

### 4. `audio_source` (`private AudioSource audio_source`)
Componnte de audio que debe ser parte del objeto jugador y que permite reproducir el sonido de objeto coleccionable cuando el jugador toca alguno de estos.

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Busca en la jerarquía los textos correspondientes a la puntuación y a los coleccionables, configura la posición inicial del jugador, actualiza la información en pantalla y configura el Audio Source obtenido desde el objeto Jugador.

### 2. `void Update()`
Función de Unity que se va ejecutando cada fotograma del juego. Calcula la puntuación con base a la posición del jugador en la escena. Imprime en pantalla los puntos obtenidos.

### 3. `void OnTriggerEnter2D(Collider2D objeto)`
Función de Unity que se encarga de detectar si el jugador colisionó con algún objeto físico. Determina si el jugador atravesó un objeto coleccionable en escena para aumentar la cantidad de coleccionables, destruir dicho objeto y reproducir el audio de objeto recogido. Actualiza el número de coleccionables en pantalla.

### 4. `float getPuntuacion()`
Devuelve los puntos recorridos durante el juego. Utilizado para mostrar la puntuación final en la escena "Fin de Juego".

### 5. `int getColeccionables()`
Devuelve el número de coleccionables obtenidos durante el juego. Utilizado para mostrar la cantidad total de coleccionables en la escena "Fin de Juego".

## Usos y Consideraciones
1. Asignar esta script como otro componente más del objeto jugador.
2. En la escena deben existir dos textos con los nombres "Puntuacion" y "Coleccionables".
3. Asignar el sonido de objeto coleccionable desde el Inspector.
