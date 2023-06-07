using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    private GameObject player;
    private GameObject interactInfo;
    public GameObject UIObject;

    private CreateCollectibles objectScript;

    private int count;

    private void Awake()
    {
        player = GameObject.Find("Player");
        interactInfo = GameObject.Find("InGame UI").transform.GetChild(0).gameObject;
        objectScript = GameObject.Find("SpawnHandler").GetComponent<CreateCollectibles>();

        count = objectScript.count;

        //interactInfo.SetActive(false);
    }

    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            interactInfo.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(gameObject);
                interactInfo.SetActive(false);
                //UIObject.SetActive(true);

                objectScript.uiImage[count].gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
