using UnityEngine;
using System.Collections;

public class Time2 : MonoBehaviour
{
    public float timer = 0;
    public int secs = 0;
    public float max = 10;
    public int duration = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Parte1();
        //Parte2();
        LogicaPar();

    }

    private void LogicaPar()
    {
        if (secs < max)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                secs++;
                if (secs % 2 == 0)
                {
                    Debug.Log("segundo   " + secs + "      par");
                }
                else
                {
                    Debug.Log("segundos  " + secs);
                }
                if (secs == max)
                {
                    Debug.Log("Terminado");
                }
            }
        }
    }

    private void Parte2()
    {
        if (duration > 0)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                duration--;
                Debug.Log("segundos  " + duration);
                if (duration == 0)
                {
                    Debug.Log("Terminado");
                }
            }
        }
    }

    private void Parte1()
    {
        if (secs < max)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                secs++;
                Debug.Log("segundos  " + secs);
                if (secs == max)
                {
                    Debug.Log("Terminado");
                }
            }
        }
    }

}
