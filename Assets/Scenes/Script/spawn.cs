using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animals;
    public Vector3 pos;


    private void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }
    void Spawn()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            pos = new Vector3(Random.Range(-15, -7), 0, Random.Range(-17, -5));
            Instantiate(animals[i], pos, animals[i].transform.rotation);
        }
    }
}
