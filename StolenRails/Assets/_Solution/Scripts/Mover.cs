using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private  CharacterController _characterController;
    private bool isinsprint = false;
    private bool issprintposible = true;

    private IEnumerator sprint()

    {
        yield return new WaitForSeconds(0.2f);
        isinsprint = false;
        _speed = 1;
        yield return new WaitForSeconds(3f);
        issprintposible = true;

    }
    void Update()
    {
        
        Vector3 motion = Vector3.zero;
        if (issprintposible&&!isinsprint&&Input.GetKey(KeyCode.LeftShift))
        {
            issprintposible = false;
            isinsprint = true;
            StartCoroutine(sprint());
            _speed = 3;
            
        }
            
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
