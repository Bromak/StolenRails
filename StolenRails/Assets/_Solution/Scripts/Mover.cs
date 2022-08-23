using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private  CharacterController _characterController;

    void Update()
    {
        
        Vector3 motion = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
        {
            motion.x += _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            motion.x -= _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            motion.z += _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            motion.z -= _speed * Time.deltaTime;
        }

        _characterController.Move(motion);
    }
}
