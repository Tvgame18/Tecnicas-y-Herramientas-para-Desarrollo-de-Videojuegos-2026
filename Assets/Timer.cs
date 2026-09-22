using System.Collections;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float Tiempo = 0f;
    public bool TimerOn = true;
    public float Tiempomaximo = 10f;
    public bool TimerOff = false;
    private int segundos = 0;
    private float segundosrestantes = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //LogicaTimer();
        //LogicaCuentaRegresiva();
    }

    void LogicaTimer()
    {
        if (TimerOn)
        {

            Tiempo += Time.deltaTime;
            if (Tiempo >= 1)
            {
                segundos++;
                Debug.Log("segundos: " + segundos);
                Tiempo = 0;
                if (segundos >= Tiempomaximo)
                {
                    TimerOn = false;
                    TimerOff = true;
                    Debug.Log("Terminado");
                }
            }
        }
    }
    void LogicaCuentaRegresiva()
    {
        if (TimerOn)
        {
            
            if (Tiempo <= Tiempomaximo)
            {
                Tiempo += Time.deltaTime;
                segundosrestantes-= Tiempo;
                Debug.Log("segundos: " + segundosrestantes);
               
                if (segundosrestantes <= 0)
                {
                    Tiempo = 0;
                    TimerOn = false;
                    TimerOff = true;
                    Debug.Log("Terminado");
                }
            }
        }
    }
}
