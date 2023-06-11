using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make the pendulum swing back and forth
        transform.rotation = Quaternion.Euler(-7.0f * Mathf.Sin(Time.time), 0.0f, 0.0f);
    }
}
