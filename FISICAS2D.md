# Fisicas2D_UNITY

Primer Ejercicio. Parte 1

En esta parte hay que provocar varias situaciones para que  nos indique las diferentes situaciones la consola. Para ello hacen falta scripts para os diversos objetos: Din�mico, Est�tico y Cinem�tico, adem�s de programarle a cada uno eventos OnCollision2D y OnTrigger2D.

A)Ninguno de los objetos son f�sicos. 

En este caso no se detecta ni colisi�n ni trigger por lo que no salta mensaje de la consola. Unity requiere que al menos de los objetos de la consola tenga un rigidbody2D. 

![1A](Imagenes/A.gif) 

B)Un objeto tiene f�sicas  y el otro no

El sprite de movimiento tiene un rigidbody2d mientras que el  sprite est�tico solo tiene el Collider2D. Como se detecta colisi�n, salta el mensaje. Como se ve, el objeto est�tico se queda quieto por mucho que el otro empuje. 

![1B](Imagenes/B.gif) 

C)Ambos tienen f�sicas.

Se detecta colisi�n, sin embargo, el objeto que est� quieto se sigue moviendo por la inercia del empuje.

![1C](Imagenes/C.gif) 

D)Ambos objetos tienen f�sicas y uno de ellos tiene 10 veces m�s masa que el otro. 

Se detecta la colisi�n, sin embargo, el segundo objeto al tener m�s masa, la inercia es m�s lenta ya que el segundo objeto pesa m�s. 

![1D](Imagenes/D.gif) 

E)Un objeto tiene f�sicas y el otro es IsTrigger. 

El sprite animado tiene el rigidbody2d, mientras que al sprite est�tico le ponemos un Collider2d. Este no entra en colisi�n, pero si entra en Trigger.

![1E](Imagenes/E.gif)

F)Ambos objetos tienen fisicas y uno es trigger.

Ambos tienen rigidbody2d activado pero uno de ellos es Trigger. Entonces no se produce colisi�n sino que pasara de largo activan el On Trigger. 

![1F](Imagenes/F.gif)

G)Uno es cinem�tico.

Se produce la colisi�n, sin embargo, el sprite con el rigidbody cinem�tico se queda quieto por mucho que el din�mico le empuje. 

![1G](Imagenes/G.gif)



PARTE 2
A)Objeto est�tico que ejerce de barrera infranqueable.

A�ado un square a la escena que transformo en una pieza m�s alta y le a�ado un Box Collider 2D. Prob� sin a�adirle ning�n componente m�s y el resultado es que la barrera se queda est�tica y no se puede pasar. 

![2A](Imagenes/2A.gif)

B)Zona en la que los objetos que caen en ella son impulsados hacia delante.

Para ello transformo el cubo para que sea un �rea m�s amplia. Como no quiero colisi�n, sino que se active al entrar en el �rea le verifico que sea trigger. Como no pasaba nada, le met� un area effector para probar. Sin embargo, al dejarle el global angle 0, el sprite en vez de salir para adelante, sal�a para la derecha, y necesitaba que saliera para la izquierda, as� que cambi� el valor de 0 a 180. 

![2B](Imagenes/2B.gif)

C)Objeto que es arrastrado por otro a una distancia fija.

Los dos objetos tienen que tener rigidbody2d. Al objeto que va a seguir al primero se le a�ade un DistanceJoint2D que har� que siga al primer objeto. Hay que tener cuidado con la distancia ya que este puede provocar que no lo siga correctamente. 

![2C](Imagenes/2C.gif)
	
D)Objeto que al colisionar con otros sigue un comportamiento totalmente f�sico. 

A�adir Box Collider al objeto y rigidbody2d

![2D](Imagenes/2D.gif)

E)Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos. 

Pues en User Layer se crean dos capas diferentes y luego a cada objeto se le asigna una capa. En este caso quiero que colisione con otro sprite en vez del cubo. Luego, en fisicas 2d, se desmarca que la capa 1 y 2 no se produzcan colisiones. 

![2E](Imagenes/2E.gif)




TILEMAPS

Actividad 1.

Creo un TileMap rectangular donde se crear� un Grid y un Tilemap que es donde voy a pintar. Cog� las im�genes de Recursos, le ajusto las dimensiones a 64x64. Se crea  la paleta seleccionando el tileset. Se separa por capas para que no me pinte el sprite y pintamos. 

![TLM1](Imagenes/TLM1.png)

Actividad 2

He creado dos tilemaps nuevos dentro del Grid que act�an como la decoraci�n y los obst�culos, se repite el mismo proceso de antes con la excepci�n de que al Tilemap obst�culo le colocamos un tilemap collider2d. Adem�s se han ordenado las capas mediante el Order in layer y un Composite Collider.

![TLM2](Imagenes/TLM2.png)

![tl2](Imagenes/TL2.gif)

Actividad 3

Seguir el pseudoc�digo para producir el movimiento. El comentario m�s relevante de la primera parte es que un transform.translate necesita 3d mientras que el vector al ser un juego en 2d pues puse Vector2.

![TLM3](Imagenes/TLM3.1.png)

![TLM3](Imagenes/TL3.1.gif)

La rotaci�n se realiza alrededor del eje Z usando el valor del eje horizontal (izquierda/derecha) multiplicado por una velocidad de rotaci�n y el tiempo entre frames. Luego, el personaje se mueve hacia adelante o atr�s usando el eje vertical (arriba/abajo).

![TLM3](Imagenes/TLM3.2.png)

![TLM3](Imagenes/TL3.2.gif)
