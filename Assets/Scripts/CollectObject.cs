using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public GameObject player;
    public GameObject interactInfo;
    public GameObject UIObject;

    private void Awake()
    {
        player = GameObject.Find("Player");
        interactInfo = GameObject.Find("CollectText");

        interactInfo.SetActive(false);
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
