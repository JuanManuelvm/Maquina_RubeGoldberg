using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    [Tooltip("El objeto que la camara debe mirar")]
    public Transform objetivo;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            transform.LookAt(objetivo);
        }
    }
}
