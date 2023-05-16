using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    private GameObject player;
    private GameObject interactInfo;
    public GameObject UIObject;

    private void Awake()
    {
        player = GameObject.Find("Player");
        interactInfo = GameObject.Find("InGame UI").transform.GetChild(0).gameObject;
        

        //interactInfo.SetActive(false);
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
                UIObject.SetActive(true);
            }
        }
    }
}
