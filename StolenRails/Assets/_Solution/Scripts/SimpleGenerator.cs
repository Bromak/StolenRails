using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGenerator : MonoBehaviour
{
    [SerializeField] private Material custom;
    void Start()
    {
        for (int x = 0; x < 100; x++)
        {
            for (int z = 0; z < 100; z++)
            {
                float perlin = Mathf.PerlinNoise(x/15f, z/15f)*10;
                GameObject Cube =GameObject.CreatePrimitive(PrimitiveType.Cube);
                Cube.transform.position = new Vector3(x, perlin, z);
                
                MeshRenderer component = Cube.GetComponent<MeshRenderer>();
                component.material = custom;
            }
        }
    }

    
   
}
