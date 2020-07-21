using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public float accelerateSpeed = 5;
    float speedMin = -20;
    float speedMax = 20;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.acceleration.x;
        float movementY = Input.acceleration.y;
        float movementZ = 0;
        transform.Translate(accelerateSpeed*movementX*Time.deltaTime,
                            accelerateSpeed*movementY*Time.deltaTime,
                            accelerateSpeed*movementZ*Time.deltaTime);

        if (accelerateSpeed >= speedMax)
            {
            accelerateSpeed = speedMax;
            }

        if(accelerateSpeed <= speedMin)
        {
            accelerateSpeed = speedMin;
        }
    }
}
