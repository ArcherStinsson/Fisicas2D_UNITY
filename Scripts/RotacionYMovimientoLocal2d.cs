using UnityEngine;

public class RotacionYMovimientoLocal2D : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 180f;

    void Update()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        float moveInput = Input.GetAxis("Vertical");

        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, -rotationAmount);

        Vector3 movement = new Vector3(0f, moveInput * speed * Time.deltaTime, 0f);
        transform.Translate(movement, Space.Self);
    }
}
