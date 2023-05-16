using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuggingPosition : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1.5f, gameObject.transform.position.z);
    }
}
