using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    [Tooltip("El objeto que la cámara debe mirar")]
    public Transform objetivo;

    [Tooltip("Tiempo en segundos que la cámara espera antes de empezar a seguir")]
    public float tiempoDeEspera = 7f;

    private float tiempoTranscurrido = 0f;
    private bool puedeSeguir = false;

    void LateUpdate()
    {
        if (objetivo == null) return;

        // Si aún no puede seguir, acumulamos el tiempo transcurrido
        if (!puedeSeguir)
        {
            tiempoTranscurrido += Time.deltaTime;

            if (tiempoTranscurrido >= tiempoDeEspera)
            {
                puedeSeguir = true;
            }
        }
        else
        {
            // Una vez pasado el tiempo, ejecuta tu código original
            transform.LookAt(objetivo);
        }
    }
}