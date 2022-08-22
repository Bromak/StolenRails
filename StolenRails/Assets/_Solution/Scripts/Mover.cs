using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            position.x += 1f*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= 1f*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.z += 1f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z -= 1f * Time.deltaTime;
        }
        transform.position = position;
    }
}
