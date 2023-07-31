# Documentación de InicializadorNivel.cs
Objeto vacío que se encuentra en la escena "Nivel" y que se encarga de clonar el prefab de un personaje jugable seleccionado desde la escena de Menu Principal.

## Variables Públicas
### 1. `prefab_sailor_moon` (`[SerializeField] private GameObject prefab_sailor_moon`)
Contiene el prefab del personaje jugable Sailor Moon

### 2. `prefab_sailor_mercury` (`[SerializeField] private GameObject prefab_sailor_mercury`)
Contiene el prefab del personaje jugable Sailor Mercury

### 3. `prefab_sailor_mars` (`[SerializeField] private GameObject prefab_sailor_mars`)
Contiene el prefab del personaje jugable Sailor Mars

### 4. `prefab_sailor_jupiter` (`[SerializeField] private GameObject prefab_sailor_jupiter`)
Contiene el prefab del personaje jugable Sailor Jupiter

### 5. `prefab_sailor_venus` (`[SerializeField] private GameObject prefab_sailor_venus`)
Contiene el prefab del personaje jugable Sailor Venus

## Métodos

### 1. `void Start()`
Función de Unity que se ejecuta una sola vez al inicio del juego. Busca al objeto cargador generado desde la escena Menu Principal, lee el valor almacenado en su posición en X, y dependiendo de ese valor instancia (clona) al prefab del personaje seleccionado.

## Usos y Consideraciones
1. Asignar esta script a un objeto vacío en la escena "Nivel 1"
2. Asignar cada uno de los prefabs de personajes jugables desde el Inspector.
