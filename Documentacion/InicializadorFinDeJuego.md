# Documentación de InicializadorFinDeJuego.cs
Objeto vacío que se encuentra en la escena "Fin del Juego" y que se encarga imprimir en pantalla el sprite del jugador correspondiente.

## Variables Públicas
### 1. `imagen_personaje` (`[SerializeField] private Image imagen_personaje`)
Referencia hacia la imagen del Canvas que renderiza la imagen de un personaje.

### 2. `sailor_moon_game_over` (`[SerializeField] private Sprite sailor_moon_game_over`)
Contiene el prefab del personaje jugable Sailor Moon

### 3. `sailor_mercury_game_over` (`[SerializeField] private Sprite sailor_mercury_game_over`)
Contiene el prefab del personaje jugable Sailor Mercury

### 4. `sailor_mars_game_over` (`[SerializeField] private Sprite sailor_mars_game_over`)
Contiene el prefab del personaje jugable Sailor Mars

### 5. `sailor_jupiter_game_over` (`[SerializeField] private Sprite sailor_jupiter_game_over`)
Contiene el prefab del personaje jugable Sailor Jupiter

### 6. `sailor_venus_game_over` (`[SerializeField] private Sprite sailor_venus_game_over`)
Contiene el prefab del personaje jugable Sailor Venus

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Busca al objeto cargador generado desde el menú principal, y dependiendo con qué personaje se haya jugado, será la imágen que se muestre en este menú de fin de partida, con una pose de "derrota" del personaje en cuestión. Destruye el objeto cargador.

## Usos y Consideraciones
1. Asignar esta script a un objeto vacío en la escena "Fin de Juego"
2. Asignar la imagen de personaje y cada uno de los sprites de personaje desde el Inspector.
