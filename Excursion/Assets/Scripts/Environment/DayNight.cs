using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class DayNight : MonoBehaviour
{
    
    public GameObject sun;
    public GameObject moon;
    
    // The maximum time for each day.
    private float timeInday;
    // Multiplier for how fast timer goes.
    public float daySpeed;
    

    void Start()
    {
        timeInday = 1;
        GameVariables.timeOfday = .5f;
    }

    
    void Update()
    {
        // Adds time to day over time.
        GameVariables.timeOfday += Time.deltaTime * daySpeed;
        // If max day time is reached the time of day starts over.
        if (GameVariables.timeOfday >= timeInday)
        {
            GameVariables.timeOfday = 0;
        }
        // Sun and moon rotate based on time.
        sun.transform.localRotation = Quaternion.Euler((GameVariables.timeOfday * 360f) - 90, 170, 0);
        moon.transform.localRotation = Quaternion.Euler((GameVariables.timeOfday * 360f) + 90, 170, 0);
    }
}
