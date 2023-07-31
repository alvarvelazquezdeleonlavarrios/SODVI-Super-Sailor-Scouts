# Documentación de MenuFinDeJuego.cs
Componente principal del objeto Menu Fin de Juego, ubicado en la escena "Fin de Juego".

## Variables Públicas
### 1. `puntuacion_total` (`[SerializeField] private Text puntuacion_total`)
Objeto de texto que muestra la puntuación final de la escena jugada previamente.

### 2. `coleccionables_total` (`[SerializeField] private Text coleccionables_total`)
Objeto de texto que muestra el número de coleccionables obtenidos en la escena jugada previamente.

## Variables Privadas
### 1. `audio_source` (`private AudioSource audio_source`)
Componente de audio de este objeto que reproduce el sonido de "clic" cuando se presiona algún botón.

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Al inicio de la escena, busca el objeto vacío llamado "Puntuación Final", obtiene sus valores en las componentes X y Y de su transform (ahí se almacenaron previamente la puntuación y los coleccionables respectivamente), y los imprime en la pantalla de este menú de fin.

### 2. `void menuPrincipal()`
Al presionar el botón de la izquierda, carga la escena de Menú Principal.

### 3. `void salir()`
Al presionar el botón de la derecha, cierra el programa.

## Usos y Consideraciones
1. Asignar esta script a un objeto vacío en la escena "Fin de Juego".
2. Asignar los textos de puntuación y coleccionables desde el Inspector.
