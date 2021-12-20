using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private void Start()
    {
        Invoke($"{nameof(arrowDestroy)}", 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(waiter());
        StopCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GameObject[] cameras = GameObject.FindGameObjectsWithTag("ArrowCamera");

        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].GetComponent<Camera>().enabled = false;
        }

        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = true;
        //Invoke($"{nameof(arrowDestroy)}", 1);
    }

    void arrowDestroy()
    {
        Destroy(gameObject);
    }
}
