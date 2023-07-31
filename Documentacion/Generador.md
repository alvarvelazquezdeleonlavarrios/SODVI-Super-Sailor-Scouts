# Documentación de Generador.cs
Componente propio del objeto de juego que es hijo de cada prefab de jugador.

## Variables Públicas
### 1. `prefabs_plataformas` (`[SerializeField] private GameObject[] prefabs_plataformas`)
Arreglo de objetos de juego que almacena los prefabs de los escenarios a generar alatoriamente. Cada escenario incluye sus coleccionables y enemigos.

### 2. `lista_plataformas_activas` (`[SerializeField] private List<GameObject> lista_plataformas_activas = new List<GameObject>()`)
Lista de objetos que se encarga de almacenar los escenarios que se vayan generando aleatoriamente durante el juego. Cada que se genera un nuevo escenario, elimina el más antiguo de la lista.

## Variables Privadas
### 1. `pos_inicio` (`private float pos_inicio`)
Se encarga de almacenar la última posición en X del generador en el instante en que se generó un nuevo escenario.

### 2. `pos_actual` (`private float pos_actual`)
Almacena la posición actual en X del generador conforme transcurre el tiempo.

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Configura la posición de inicio en 0, busca el escenario que se encuentra al inicio de la escena y la agrega a la lista de plataformas.

### 2. `void Update()`
Función de Unity que se va ejecutando cada fotograma del juego. Permite ejecutar la función encargada de generar los escenarios aleatoriamente.

### 3. `void generarPlataformaAleatoria()`
Genera un escenario aleatorio. Si la distancia entre la posición actual y la última posición registrada del generador es mayor o igual a 40, se genera un nuevo objeto a partir del prefab de alguno de los escenarios del arreglo de plataformas. Guarda la nueva plataforma en la lista, y si el tamaño de esta es mayor o igual a 3, destruye y elimina el primer elemento de la lista. Vuelve a configurar la última posición de inicio con respecto a la actual.

## Usos y Consideraciones
1. Asignar esta script a un objeto vacío en la escena "Nivel 1". Debe ser hijo del objeto Jugador y estar situado a 40 unidades a la derecha de este.
2. El arreglo de prefabs de plataformas debe tener por lo menos un elemento.
3. Cada prefabricado de escenario debe tener una longitud de 40 unidades métricas y su centro debe ubicarse a la mitad (es decir, debe medir desde -20 hasta 20 en el eje X)
4. En la escena "Nivel 1", al inicio debe existir un único objeto llamado "Plataforma 1" para que este pueda ser agregado a la lista y, posteriormente, eliminado.
