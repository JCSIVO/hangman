# hangman
Recreation of the hangman game


// Elaboración del juego del Ahorcado (HangMan) en C# por JCSIVO (23-12-2022).

// Lógica del programa.
/*
* 1. De un conjunto de palabras prefijadas, el equipo coge una al azar. 
* 2. La palabra escogida en el punto anterior se muestra como oculta y muestra una serie de guiones (--- ---).
* 3. El usuario elige una letra
* 4. Se comprueba si la letra introducida forma parte de la escogida al azar y 
*    en caso de que NO, el usuario pierde un intento del total de la palabra. 
* 5. Si la letra SI forma parte, el jugador no pierde ningún intento y esa palabra es sustituida por los guiones correspondientes. 
* 6. El programa debe de estar dentro de una estructura de repetición (desde el punto dos), hasta que el usuario 
*    acierta TODA la palabra o se queda sin INTENTOS.
*/
