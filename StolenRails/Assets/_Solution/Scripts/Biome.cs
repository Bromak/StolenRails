using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Biome", menuName = "Biome", order = 51)]
public class Biome : ScriptableObject
{
    [SerializeField] private GameObject _tree;
    [SerializeField] private GameObject _water;
    [SerializeField] private GameObject _iron;
    [SerializeField] private GameObject _grass;
    [SerializeField] private GameObject _stone;

    public GameObject Tree => _tree;
    public GameObject Water => _water;
    public GameObject Iron => _iron;
    public GameObject Grass => _grass;
    public GameObject Stone => _stone;
}