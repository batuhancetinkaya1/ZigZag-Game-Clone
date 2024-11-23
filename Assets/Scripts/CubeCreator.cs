using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CubeCreator : MonoBehaviour
{
    Random random = new Random();

    [SerializeField] GameObject cubePrefab;

    [SerializeField] List<GameObject> cubes = new List<GameObject>(); //We are using same cubes so we keep them in list

    [SerializeField] Vector3 spawnPosition = Vector3.zero;

    [SerializeField] bool isLeft = false; // true -> x axis, false -> z axis
    [SerializeField] int spawnPositionValue = -1; //it could be constant but we are keeping it vraible because we could change cube dimensions

    [SerializeField] int maxCubeCount = 50;

    [SerializeField] float cubeMinFallPosition = -5f;

    

    void Start()
    {
        InitialCubeSpawner();
    }

    private void LateUpdate()
    {
        AutomaticCubeSpawner();
    }

    private void InitialCubeSpawner()
    {
        InitialSpawnPositionDecider();

        for (int i = 0; i < maxCubeCount; i++)
        {
            GameObject cubeToCreate = Instantiate(cubePrefab, CubeSpawnPositionDecider(CubeSpawnDirectionnDecider()), Quaternion.identity);
            cubes.Add(cubeToCreate);
        }
    }

    private void InitialSpawnPositionDecider()
    {
        spawnPosition = new Vector3(0.5f, 0, 0.5f);
    }

    private bool CubeSpawnDirectionnDecider()
    {
        isLeft = random.Next(0, 2) == 1;
        return isLeft;
    }

    private Vector3 CubeSpawnPositionDecider(bool spawnDirection)
    {
       if(spawnDirection)
       {
            spawnPosition += new Vector3(0, 0, spawnPositionValue); //Her yeni küp oluþtuðunda spawnposition kayacak x y Z
       }
       else if (!spawnDirection)
       {
            spawnPosition += new Vector3(spawnPositionValue, 0, 0); //Her yeni küp oluþtuðunda spawnPosition kayacak X y z
       }
       return spawnPosition;
    }


    /// <summary>
    /// This method use initial cubes so there is no Instantiate
    /// </summary>
    private void AutomaticCubeSpawner() 
    {
        foreach(GameObject cube in cubes)
        {
            if (cube.transform.position.y < cubeMinFallPosition)
            {
                cube.GetComponent<Cube>().CubeReset();
                cube.transform.position = CubeSpawnPositionDecider(CubeSpawnDirectionnDecider());
            }
        }
    }
}