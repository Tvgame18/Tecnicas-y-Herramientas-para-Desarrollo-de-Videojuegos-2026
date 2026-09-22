using System;
using UnityEngine;

public class PracticaClase4 : MonoBehaviour
{

    // Este cs esta comentado de tal manera para que se pueda ir probando ejercicio por ejercicio
    // eso si, entender el orden de ejecucion para saber que descomentar o no
    // Ejemplo: no pueden haber dos Updates()

    int segundos = 0;
    float tiempo = 0;
    int duracion = 10;
    bool terminado = false;
    int segundosRestantes = 10;
    int[] segundosPares = new int[5];
    int posicionArray = 0;
    

    // EJERCICIO N1: Contador de segundos
    // Crear un timer que comience en 0 y muestre en la consola un mensaje cada vez que trascurra un segundo
    // El resultado deberia ser: segundo: 1, segundo: 2.... indefinidiamente


    /*void Update() 
    {
        
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            segundos++;
            
            Debug.Log("Segundo: " + segundos); 
            
            tiempo = 0;

        }

    }*/


    // EJERCICIO N2: Timer con duración
    // Modificar el timer anterior para que tenga una duración determinada.
    // La duración debe almacenarse en una variable: int duracion = 10;
    // El timer debe detenerse cuando llegue a esa cantidad de segundos.
    // Agregar un mensaje solamente cuando termine

    /*void Update() 
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                
                Debug.Log("Segundo: " + segundos); 
                
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;

                    Debug.Log("Timer terminado"); 
                }

            }
        }

    }*/


    // EJERCICIO N3: Pasar el timer a un método
    // Modificar el ejercicio anterior para que el timer sea ejecutado mediante un método

    void Update()
    {
        //LogicaTimer();
        //LogicaCuentaRegresiva();
        //LogicaTimerPar();
    }

    void LogicaTimer()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                
                Debug.Log("Segundo: " + segundos); 
                
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;

                    Debug.Log("Timer terminado"); 
                }

            }
        }
    }

    // EJERCICIO N4: Cuenta regresiva
    // Crear un metodo de un timer que funcione como cuenta regresiva.
    // Si la duracion es 10 debe mostrar: Tiempo restante: 10, Tiempo restante: 9... Hasta llegar a 0, y enunciar que termino
    
    void LogicaCuentaRegresiva()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundosRestantes--;
                
                Debug.Log("Tiempo restante: " + segundosRestantes); 
                
                tiempo = 0;

                if (segundosRestantes <= 0)
                {
                    terminado = true;

                    Debug.Log("Timer terminado"); 
                }

            }
        }
    }

}
