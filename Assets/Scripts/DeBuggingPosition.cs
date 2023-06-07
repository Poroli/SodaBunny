using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuggingPosition : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeBug")
        {
            rb.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 1.5f, Random.Range(-4.5f, 4.5f));
        }
    }
}
