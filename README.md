# Super-Sailor-Scouts

**Equipo:** El Infiltrado de SODVI :v

**Integrantes:**
- Alvar Velázquez de León Lavarrios

**Semestre:** 2024-1

**Torre de Niveles:** Nivel -1: "Infiltrado" (No supe qué poner aquí...)

## Introducción
Proyecto individual sobre un Endless Runner de Sailor Moon para aprender las características básicas de un juego 2D en Unity. Proyecto hecho para el curso de Unity Básico de SODVI.

## Descripción del Proyecto
Este proyecto partió con la idea de primero crear a los personajes jugables. Agregué a más de un personaje jugable para que el usuario pueda seleccionar con quién jugar. Esto lo pude hacer programando una sentencia switch-case, asignando valores a botones en pantalla, y mediante la función *DontDestroyOnLoad* llevar un transform con dicho valor para que al inicio de la escena de nivel se genere al personaje en cuestión.

![Imagen 1-1](/src/Imagen1-1.png)
![Imagen 1-2](/src/Imagen1-2.png)

Luego importé las imágenes correspondientes para cada escenario que más adelante se generaría aleatoriamente. A cada uno de estos configuré sus respectivas cajas de colisión para que el jugador pudiese caminar sobre los escenarios, además de que estos tienen un tamaño de 40 unidades métricas. Esto último lo hice para que los escenarios se fuesen generando sin que hubiesen huecos entre ellos y  porque en el código permite generarlos con respecto a la posición en del generador en el eje X en lugar de pasado cierto tiempo (evita generar suelos traslapados).

![Imagen 2-1](/src/Imagen2-1.png)
![Imagen 2-2](/src/Imagen2-2.png)

Con respecto a la destrucción de los escenarios más antiguos, el método con el que se me ocurrió realizarlo fue mediante la implementación de listas: al cumplir las condiciones para generar un nuevo escenario, en lugar de únicamente crear un clon del prefab, toma la referencia y la agrega (hasta la última posición) en una lista ligada. Al mismo tiempo, el escenario que se encuentra en la primera posición de la lista (que sería el escenario más a la izquierda de la pantalla) lo destruye y borra la referencia de la lista, liberando espacio.

![Imagen 3-1](/src/Imagen3-1.png)


Los escenarios los realicé de tal forma que no fuesen completamente planos para darle algo de variedad al gameplay, agregando a cada uno de estos distintos tipos de enemigos pero que mecánicamente se comportan igual: si el jugador los toca, finaliza la partida. También cada escenario se genera con sus respectivos coleccionables ya definidos desde el prefab.

![Imagen 4-1](/src/Imagen4-1.png)
![Imagen 4-2](/src/Imagen4-2.png)
![Imagen 4-3](/src/Imagen4-3.png)

Cada personaje jugable emite sus propias animaciones de caminar y salto, y cada enemigo su animación propia de reposo. Otro aspecto importante fue considerar el caso en el que el jugador cae al vacío por alguna razón: para ello en la script del jugador, en la función *Update*, consideré que si la posición en Y era menor a un valor establecido, terminaba la partida cargando la escena de fin de partida.

![Imagen 5-1](/src/Imagen5-1.png)

Por último, la puntuación final y la cantidad de coleccionables las programé de tal manera que también puedan verse en la pantalla de fin de partida. Esto lo logré hacer almacenando ambos valores en un transform y llevándolo a la escena de fin de juego mediante la función *DontDestroyOnLoad*. Dependiendo con qué jugador se haya jugado, este también aparecerá en la pantalla de fin de juego

![Imagen 6-1](/src/Imagen6-1.png)

## Conclusión
De la realización de este proyecto puedo mencionar que el desarrollo de un juego en 2D rquiere de bastante esmero y dedicación para lograr los resultados deseados, además de conocer y aprender la lógica del movimiento de objetos de juego, interacciones mediante físicas, mostrar información en pantalla mediante un Canvas, cambios de escena y, obviamente, programación (principalmente Orientada a Objetos).
