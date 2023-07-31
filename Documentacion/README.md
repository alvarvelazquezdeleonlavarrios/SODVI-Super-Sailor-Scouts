# Documentación del Proyecto

A continuación, se muestra un listado de las scripts programadas en C# que conforman el funcionamiento del proyecto, con uan breve descripción de la función principal que realizan:

1. [Jugador.cs](/Documentacion/Jugador.md): controla los movimientos básicos del jugador (caminar y saltar). Lleva el control de las animaciones, audios, y colisiones con los diferentes objetos interactuables del nivel.

2. [Generador.cs](/Documentacion/Generador.md): se encarga de generar de manera aleatoria las plataformas, junto con sus enemigos y coleccionables, hacia la derecha del jugador para que este siga avanzando en el nivel. Además de ir generando el escenario hacia la derecha de la pantalla, va borrando las secciones de escenario que se encuentran a la izquierda.

3. [MenuPrincipal.cs](/Documentacion/MenuPrincipal.md): lleva el control del menú principal. Permite la selección del personaje jugable, volver a la pantalla principal y cargar la escena del nivel de juego.

4. [InicializadorNivel.cs](/Documentacion/InicializadorNivel.md): dependiendo del personaje jugable seleccionado desde el menú principal, permite generar en la escena del nivel de juego al prefab del jugador en cuestión.

5. [MenuFinDeJuego.cs](/Documentacion/MenuFinDeJuego.md): controla la lógica de la pantalla que se muestra cuando el jugador pierde la partida. Permite volver al menú principal o salir del juego. Además, imprime en pantalla la puntuación final y la cantidad de coleccionables obtenidos como resultado de la partida jugada en la escena previa.

6. [InicializadorFinDeJuego.cs](/Documentacion/InicializadorFinDeJuego.md): dependiendo con qué personaje se haya jugado desde la escena de Nivel, mostrará en la pantalla de fin de juego una imagen del personaje en cuestión en una pose de "derrota".

7. [Puntaje.cs](/Documentacion/Puntaje.md): script que permite llevar el conteo de la puntuación (en función de la distancia recorrida por el jugador) y el número de objetos interactuables. Esta script va como componente del objeto Jugador.
