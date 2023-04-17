using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] planets;
    void Start()
    {
        GameObject World = new GameObject("World");
        for(int i = 0; i < 100; ++i)
        {
            float xPos = Random.Range(-100f, 100f);
            float yPos = Random.Range(-100f, 100f);
            float zPos = Random.Range(-100f, 100f);
            var newPlanet = Instantiate(planets[Random.Range(0, planets.Length)], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            newPlanet.transform.SetParent(World.transform);
            newPlanet.transform.localScale = new Vector3(10, 10, 10);
            newPlanet.name = "Planet " + i;
        }
    }
}
