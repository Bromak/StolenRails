using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Biome", menuName = "Biome", order = 51)]
public class Biome : ScriptableObject
{
    [SerializeField] private GameObject Tree;
    [SerializeField] private GameObject Water;
    [SerializeField] private GameObject Iron;
    [SerializeField] private GameObject Grass;
    [SerializeField] private GameObject Stone;
}