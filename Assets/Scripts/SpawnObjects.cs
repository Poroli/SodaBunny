using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnableObjects;
    [SerializeField] private Image[] objectImages;
    
    public enum Objects { Ball1, BrickOne1, BrickTwo1, Book1, Glass1, Candle1, Bowl1, Plate1, Ball2, BrickOne2, BrickTwo2, Book2, Glass2, Candle2, Bowl2, Plate2}

    [SerializeField] private Objects objects = 0;
    [SerializeField] private Image objectPicture;
    [SerializeField] private GameObject objectToSpawn;

    private void Awake()
    {
        ObjectsToSpawn();
    }

    public void ObjectsToSpawn()
    {
        for (int i = 0; i < 50; i++)
        {
            objects = (Objects)Random.Range(0, 15);

            SetObjectsToName();

            Instantiate(objectToSpawn, new Vector3(Random.Range(-4.5f, 4.5f), 1.5f, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
        }
    }

    private void SetObjectsToName()
    {
        if (objects == Objects.Ball1)
        {
            objectToSpawn = spawnableObjects[0];
            objectPicture = objectImages[0];
        }

        if (objects == Objects.Ball2)
        {
            objectToSpawn = spawnableObjects[1];
            objectPicture = objectImages[1];
        }

        if (objects == Objects.Book1)
        {
            objectToSpawn = spawnableObjects[2];
            objectPicture = objectImages[2];
        }

        if (objects == Objects.Book2)
        {
            objectToSpawn = spawnableObjects[3];
            objectPicture = objectImages[3];
        }

        if (objects == Objects.Bowl1)
        {
            objectToSpawn = spawnableObjects[4];
            objectPicture = objectImages[4];
        }

        if (objects == Objects.Bowl2)
        {
            objectToSpawn = spawnableObjects[5];
            objectPicture = objectImages[5];
        }

        if (objects == Objects.BrickOne1)
        {
            objectToSpawn = spawnableObjects[6];
            objectPicture = objectImages[6];
        }

        if (objects == Objects.BrickOne2)
        {
            objectToSpawn = spawnableObjects[7];
            objectPicture = objectImages[7];
        }

        if (objects == Objects.BrickTwo1)
        {
            objectToSpawn = spawnableObjects[8];
            objectPicture = objectImages[8];
        }

        if (objects == Objects.BrickTwo2)
        {
            objectToSpawn = spawnableObjects[9];
            objectPicture = objectImages[9];
        }

        if (objects == Objects.Candle1)
        {
            objectToSpawn = spawnableObjects[10];
            objectPicture = objectImages[10];
        }

        if (objects == Objects.Candle2)
        {
            objectToSpawn = spawnableObjects[11];
            objectPicture = objectImages[11];
        }

        if (objects == Objects.Glass1)
        {
            objectToSpawn = spawnableObjects[12];
            objectPicture = objectImages[12];
        }

        if (objects == Objects.Glass2)
        {
            objectToSpawn = spawnableObjects[13];
            objectPicture = objectImages[13];
        }

        if (objects == Objects.Plate1)
        {
            objectToSpawn = spawnableObjects[14];
            objectPicture = objectImages[14];
        }

        if (objects == Objects.Plate2)
        {
            objectToSpawn = spawnableObjects[15];
            objectPicture = objectImages[15];
        }
    }
}
