using UnityEngine;

public class LightingSetting : MonoBehaviour
{

    void Start()
    {
        RenderSettings.ambientIntensity = 0.0f;
    }

    void Update()
    {
        RenderSettings.ambientIntensity = Mathf.Sin(Time.time)) ;

        RenderSettings.fog = true;
        RenderSettings.fogStartDistance = 1.0f;
    }
}
