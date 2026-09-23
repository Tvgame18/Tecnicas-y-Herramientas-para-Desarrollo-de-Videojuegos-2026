using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;
    public InputActionReference inputMovimiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lecturaInput = inputMovimiento.action.ReadValue<Vector2>();
        Vector3 direccion = new Vector3(lecturaInput.x, 0, lecturaInput.y);
        transform.position += direccion.normalized * velocidad * Time.deltaTime;
    }
}
