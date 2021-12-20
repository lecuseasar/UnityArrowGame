using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    public List<GameObject> arrowGameOjects;
    public Slider sliderObject;
    public AudioSource stretchSound;

    public float stretch;
    public float stretchSpeed = 5;
    public float stretchMax = 50;

    private int itemNumbers = 1;


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
            ShootCustomArrow(itemNumbers);
            // sound
            stretchSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            itemNumbers = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            itemNumbers = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            itemNumbers = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            itemNumbers = 4;
        }
    }
    void ShootArrow(GameObject gameObject, float arrowSpeed)
    {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        GameObject arrow = Instantiate(gameObject, camera.transform.position, camera.transform.rotation);
        arrow.transform.Rotate(0, 90, 0);
        arrow.GetComponent<Rigidbody>().velocity = camera.transform.forward * arrowSpeed;
    }
    void ShootCustomArrow(int itemNum)
    {
        switch (itemNum)
        {
            case 1:
                ShootArrow(arrowGameOjects[0], stretch);
                stretch = 0;
                sliderObject.value = 0;
                break;
            case 2:
                ShootArrow(arrowGameOjects[1], stretch);
                stretch = 0;
                sliderObject.value = 0;
                break;
            case 3:
                ShootArrow(arrowGameOjects[2], stretch);
                stretch = 0;
                sliderObject.value = 0;
                break;
            case 4:
                ShootArrow(arrowGameOjects[3], stretch);
                stretch = 0;
                sliderObject.value = 0;
                break;
        }
    }
}
