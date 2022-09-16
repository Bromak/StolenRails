using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SimpleGenerator : MonoBehaviour
{
    [SerializeField] private Biome biome;
    private Vector3 _playerSpawnPosition = new Vector3(15, 0, 15);
    private int _safeZoneRadius = 7;

    void Start()
    {
        for (int x = 0; x < 100; x++)
        {
            for (int z = 0; z < 20; z++)
            {
                Vector3 blockPosition = new Vector3(x, 0, z);
                float perlin = Mathf.PerlinNoise(x / 15f, z / 15f);
                Vector3 difference =_playerSpawnPosition - blockPosition;
                if (difference.magnitude < 7)
                {
                    Instantiate(biome.Grass, blockPosition, Quaternion.identity);
                }
                else if (perlin > 0.8f)
                {
                    Instantiate(biome.Stone, blockPosition, Quaternion.identity);
                }
                else if (perlin > 0.6f)
                {
                    Instantiate(biome.Iron, blockPosition, Quaternion.identity);
                }
                else if (perlin > 0.5f)
                {
                    Instantiate(biome.Tree, blockPosition, Quaternion.identity);
                }
                else if (perlin > 0.3f)
                {
                    Instantiate(biome.Grass, blockPosition, Quaternion.identity);
                }
                else
                {
                    Instantiate(biome.Water, blockPosition, Quaternion.identity);
                }
            }
        }
    }
}
