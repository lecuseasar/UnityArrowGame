using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    public GameObject arrowGameOject;

    public GameObject arrowGameOject2;
    public Slider sliderObject;

    public float stretch;
    public float stretchSpeed = 5;
    public float stretchMax = 50;

    private int itemNumbers = 1;

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
            if (itemNumbers == 1)
            {
                ShootArrow(arrowGameOject, stretch);
                stretch = 0;
                sliderObject.value = 0;
            }
            if (itemNumbers == 2)
            {
                ShootArrow(arrowGameOject2, stretch);
                stretch = 0;
                sliderObject.value = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            itemNumbers = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            itemNumbers = 2;
        }
    }
    void ShootArrow(GameObject gameObject, float arrowSpeed)
    {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        GameObject arrow = Instantiate(gameObject, camera.transform.position, camera.transform.rotation);
        arrow.transform.Rotate(0, 90, 0);
        arrow.GetComponent<Rigidbody>().velocity = camera.transform.forward * arrowSpeed;
    }
}
