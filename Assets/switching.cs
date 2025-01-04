using UnityEngine;

public class switching : MonoBehaviour
{
    // Public variable to specify the number of lights
    public int numberOfLights;

    // Array to hold references to lights
    public Light[] lights;

    // Function to toggle the state of all lights
    public void ToggleLights()
    {
        foreach (Light light in lights)
        {
            if (light != null)
            {
                light.enabled = !light.enabled; // Enable if disabled, disable if enabled
            }
        }
    }

    // Debugging: Press 'T' to toggle lights in Play mode
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleLights();
        }
    }
}
