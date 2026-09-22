using UnityEngine;
using System.Collections;

public class Time2 : MonoBehaviour
{
    public float timer = 0;
    public int secs = 0;
    public float max = 10;
    public int duration = 10;
    public int[] pares = new int[5];
    public int indice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //LogicaTimer();
        //LogicaCuentaRegresiva();
        //LogicaPar();
        //LogicaParConFor();
        //LogicaParConWhile();
    }

    private void LogicaParConWhile()
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
                    pares[indice] = secs;
                    indice++;
                    Debug.Log("segundo   " + secs + "      par");
                }
                else
                {
                    Debug.Log("segundos  " + secs);
                }
                if (secs == max)
                {
                    Debug.Log("pares");
                    int i = 0;
                    while (i < pares.Length)
                    {
                        Debug.Log(pares[i]);
                        i++;
                    }
                }
            }
        }
    }

    private void LogicaParConFor()
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
                    pares[indice] = secs;
                    indice++;
                    Debug.Log("segundo   " + secs + "      par");
                }
                else
                {
                    Debug.Log("segundos  " + secs);
                }
                if (secs == max)
                {
                    Debug.Log("pares");
                    for (int i = 0; i < pares.Length; i++)
                    {
                        Debug.Log(pares[i]);
                    }
                }
            }
        }
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

    private void LogicaCuentaRegresiva()
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

    private void LogicaTimer()
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
