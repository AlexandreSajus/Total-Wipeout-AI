using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLauncher : MonoBehaviour
{

    public GameObject cube; 
    public GameObject walker;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Cube object from the scene
        cube = GameObject.Find("Cube");
        walker = GameObject.Find("hips");
    }

    // Update is called once per frame
    void Update()
    {
        // When the player presses spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn a cube on the camera
            GameObject newCube = Instantiate(cube, transform.position, transform.rotation);

            // Get the vector of where the camera is looking
            Vector3 direction = transform.forward;

            // Throw the cube in the direction of the walker
            newCube.GetComponent<Rigidbody>().AddForce(direction * 200);
        }
    }
}
