using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    public GameObject arrowGameOject;
    public Slider sliderObject;

    public float stretch;
    public float stretchSpeed = 5;
    public float stretchMax = 50;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && stretch < stretchMax) // left click
        {
            stretch += stretchSpeed * Time.deltaTime;
            sliderObject.value = stretch;

        }

        if (Input.GetMouseButtonUp(0))
        {
            ShootArrow(stretch);
            stretch = 0;
            sliderObject.value = 0;
        }
    }
    void ShootArrow(float arrowSpeed)
    {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        GameObject arrow = Instantiate(arrowGameOject, camera.transform.position, camera.transform.rotation);
        arrow.transform.Rotate(0, 90, 0);
        arrow.GetComponent<Rigidbody>().velocity = camera.transform.forward * arrowSpeed;
    }
}
