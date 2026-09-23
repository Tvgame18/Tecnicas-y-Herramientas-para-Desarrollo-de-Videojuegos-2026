using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidad = 3f;
    public Transform player;
    private Rigidbody rb;
    public float distanciaVision = 10f;
    public float anguloVision = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direccionAlplayer = player.position - transform.position;

        if (direccionAlplayer.magnitude <= distanciaVision)
        {
            float angulo = Vector3.Angle(transform.forward, direccionAlplayer);

            if (angulo <= anguloVision / 2)
            {
                Vector3 direccion = direccionAlplayer.normalized;

                rb.MovePosition(
                    rb.position + direccion * velocidad * Time.fixedDeltaTime
                );
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(
            transform.position,
            distanciaVision
        );

        Vector3 direccionIzquierda =
            Quaternion.Euler(0, -anguloVision / 2, 0)
            * transform.forward;

        Vector3 direccionDerecha =
            Quaternion.Euler(0, anguloVision / 2, 0)
            * transform.forward;

        Gizmos.DrawLine(
            transform.position,
            transform.position + direccionIzquierda * distanciaVision
        );

        Gizmos.DrawLine(
            transform.position,
            transform.position + direccionDerecha * distanciaVision
        );
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
