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


using System;

public class Ahorcado{

    public static void Main(){

        // 1. Se genera la lista y el ordenador coge una al azar de entre las prefijadas 


        string[] heroes = {"Gamora", "SpiderMan", "Hulk", "Superman", "Thor", "Catwoman", "Superwoman", "Batman"};

        Random heroeAleatorio = new Random();
        int numeroAzar = heroeAleatorio.Next(0, heroes.Length);
        String heroeAdivinar = heroes[ numeroAzar ];
        string heroeMinuscula = heroeAdivinar.ToLower(); 
        // Console.WriteLine(heroeAdivinar);
        
        
        // 1a. La palabra escogida se muestra con una serie de guiones: --- --- 

            string palabraMostrar = "";
            for (int i = 0; i < heroeMinuscula.Length; i++){
                if (heroeAdivinar[i] == ' '){
                    palabraMostrar += " ";
                }else {
                    palabraMostrar += "-";
                }
            }
            // Console.WriteLine(palabraMostrar);


        // Variables que se emplena en la parte repetitiva

            int fallosRestantes = heroeAdivinar.Length;
            char letraIntroducida;
            // char letraMinuscula ;
            bool terminado = false;


        // 6. Parte repetitiva del programa

        do{    

        // 2. Se muestra palabra oculta y los fallos restantes que el quedan

            Console.WriteLine("Palabra oculta: {0}", palabraMostrar);
            Console.WriteLine("Fallos restantes: {0}" , fallosRestantes);


        // 3. El usuario elige una letra

            Console.Write("Introduce una letra: ");
            letraIntroducida = Convert.ToChar( Console.ReadLine().ToLower() );
            // letraMinuscula = char.ToLower(letraIntroducida);
            // Console.WriteLine(letraIntroducida);


        // 4. Si la letra NO forma parte de la palabra escogida, el jugador 
        //    pierde un intento del total de la palabra escogida

            if(heroeMinuscula.IndexOf(letraIntroducida) == -1){
                fallosRestantes--; 
                // Console.WriteLine(fallosRestantes);
                
                // En caso de perder un intento se llama a la funcón para que represente el patíbulo
                mostrarPatibulo(fallosRestantes);
            }


        // 5. Si la letra SI forma parte de la palabra escogida, el jugador no pierde ningún intento,
        //    y la letra sustituye a los guiones correspondientes. ( batman -> -a--a- )

            string palabraIntroducida = "";
            for(int i = 0; i < heroeMinuscula.Length; i++){
                if (letraIntroducida == heroeMinuscula[i]){
                    palabraIntroducida += letraIntroducida;
                }else
                    palabraIntroducida += palabraMostrar[i]; 
            }

            palabraMostrar = palabraIntroducida;
            // Console.WriteLine(palabraMostrar);


        // 6a. Comprobación si el usuario ha acertado la palabra escogida ó
        //     Se ha quedado sin intentos y ha fallado 

            if(palabraMostrar.IndexOf("-") < 0){
                Console.WriteLine("Enhorabuena has acertado, el heroe es: " + heroeAdivinar);
                terminado = true;
            }


            if(fallosRestantes == 0){
                Console.WriteLine("Lo siento no has acertado, el heroe era: " + heroeAdivinar);
                terminado = true;
            }

            Console.WriteLine();


        }while(!terminado);
    }  


    // Recreación simbólica del patíbulo 

    static void mostrarPatibulo(int fallosRestantes){

        switch (fallosRestantes)
        {
            case 11:
            case 10:
            case 9:
            case 8:
            case 7: 
                Console.WriteLine("-");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
            break;

            case 6:
                Console.WriteLine("--------");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
            break;
            
            case 5:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;

            case 4:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;

            case 3:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 2:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|\\");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 1:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|\\");
                Console.WriteLine("|    /");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 0:
                Console.WriteLine("--------");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|\\");
                Console.WriteLine("|    / \\");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
        }
    }
}
