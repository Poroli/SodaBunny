using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCollectibles : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnableObjects;
    [SerializeField] private Sprite[] objectImages;
    [SerializeField] private Image[] uiImage;

    public enum CollectObjects { Ball, BrickOne, BrickTwo, Book, Glass, Candle, Bowl, Plate }

    [SerializeField] private CollectObjects objects = 0;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Sprite collectedImage;

    private void Awake()
    {
        ObjectsToSpawn();
    }

    public void ObjectsToSpawn()
    {
        for (int i = 0; i < 8; i++)
        {
            objects = (CollectObjects)Random.Range(0, 7);

            SetObjectsToName();

            Instantiate(objectToSpawn, new Vector3(Random.Range(-4.5f, 4.5f), 1.5f, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
            uiImage[i].sprite = collectedImage;
        }
    }

    private void SetObjectsToName()
    {
        if (objects == CollectObjects.Ball)
        {
            objectToSpawn = spawnableObjects[0];
            collectedImage = objectImages[0];
        }

        if (objects == CollectObjects.Book)
        {
            objectToSpawn = spawnableObjects[1];
            collectedImage = objectImages[1];
        }

        if (objects == CollectObjects.Bowl)
        {
            objectToSpawn = spawnableObjects[2];
            collectedImage = objectImages[2];
        }

        if (objects == CollectObjects.BrickOne)
        {
            objectToSpawn = spawnableObjects[3];
            collectedImage = objectImages[3];
        }

        if (objects == CollectObjects.BrickTwo)
        {
            objectToSpawn = spawnableObjects[4];
            collectedImage = objectImages[4];
        }

        if (objects == CollectObjects.Candle)
        {
            objectToSpawn = spawnableObjects[5];
            collectedImage = objectImages[5];
        }

        if (objects == CollectObjects.Glass)
        {
            objectToSpawn = spawnableObjects[6];
            collectedImage = objectImages[6];
        }

        if (objects == CollectObjects.Plate)
        {
            objectToSpawn = spawnableObjects[7];
            collectedImage = objectImages[7];
        }
    }
}
