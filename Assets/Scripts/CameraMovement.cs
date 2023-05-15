using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // el objeto a seguir (el personaje principal)
    public float smoothSpeed = 0.125f; // la suavidad del seguimiento de la c�mara
    public Vector3 offset; // la posici�n relativa de la c�mara con respecto al objeto a seguir
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, transform.position.y, transform.position.z);
    }
}
