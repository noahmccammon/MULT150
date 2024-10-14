using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("flashlight clicking noise");
        if (lightComponent.intensity != 0)
            lightComponent.intensity = 0;
        else lightComponent.intensity = 4;
        }

    }
}
