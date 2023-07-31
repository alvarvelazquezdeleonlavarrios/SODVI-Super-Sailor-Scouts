# Documentación de MenuPrincipal.cs
Componente principal del menú principal, ubicado en la escena "Menu Prinicpal".

## Variables Públicas
### 1. `pantalla_principal` (`[SerializeField] private GameObject pantalla_principal`)
Objeto del Canvas que contiene cada elemento de la pantalla del menú principal. Viene representado como un Panel que contiene los botones de jugar y salir.

### 2. `pantalla_seleccion_personaje` (`[SerializeField] private GameObject pantalla_seleccion_personaje`)
Objeto del Canvas que contiene cada elemento de la pantalla de selección del personaje. Viene representado como un Panel que contiene los botones de los 5 personajes jugables.

### 3. `flecha_seleccion` (`[SerializeField] private Image flecha_seleccion`)
Objeto de tipo imagen que indica al personaje jugable seleccionado resultado de dar clic en su respectivo botón.

### 4. `cargador` (`[SerializeField] private GameObject cargador`)
Objeto de juego vacío encargado de almacenar un valor entero en alguno de sus componentes correspondiente al personaje jugable seleccionado.


## Variables Privadas
### 1. `sailor_scout` (`private SailorScout sailor_scout`)
Variable de tipo enum que indica el personaje jugable elejido. Se puede elejir entre 5 valores:
- Sailor Moon
- Sailor Mercury
- Sailor Mars
- Sailor Jupiter
- Sailor Venus

### 2. `audio_source` (`private AudioSource audio_source`)
Componente de audio propio del objeto Menu Principal que se encarga de reproducir un sonido de "clic" cuando se presiona algún botón.

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Desactiva todas las pantallas a excepción de la pantalla principal.

### 2. `void activarMenuSeleccionPersonaje()`
Activa la pantalla de selección de personaje para que el usuario pueda interactuar con esta. Desactiva la pantalla de inicio.

### 3. `void volverPantallaPrincipal()`
Permite regresar a la pantalla de inicio, desactivando por completo la pantalla de selección.

### 4. `void seleccionarPersonaje(int personaje_id)`
Dependiendo el botón que se haya presionado en la pantalla de selección, configura la variable sailor_scout indicando que personaje jugable se tiene seleccionado en el momento actual.

### 5. `void cargarEscena(string nombre)`
Se encarga de cargar la escena del nivel, almacenando el "id" del personaje jugable que se seleccionó en el cargador y llamando al Scene Manager para cargar la escena Nivel 1.

### 6. `void cerrarJuego()`
Cierra el programa

## Usos y Consideraciones
1. Asignar esta script a un objeto vacío en la escena "Menu Principal"
2. Los objetos pantalla_principal, pantalla_seleccion_personaje, flecha_seleccion y cargador deben asignarse desde el Enspector. El cargador es únicamente un objeto vacío con su Transform.
3. Las pantallas deben ser paneles del Canvas.
