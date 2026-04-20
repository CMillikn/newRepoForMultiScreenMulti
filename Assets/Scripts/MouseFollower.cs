using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollower : MonoBehaviour
{
    public float lerpSpeed;
    Vector3 mousePosition;
    Mouse currentMouse;
    public GameObject playerGO;
    public Camera mainCam;


    public void Start()
    {
        currentMouse = Mouse.current;
        //mainCam = Camera.main;
    }

    // Update is called once per frame
    public void Update()
    {
        //mainCam = Camera.main;
        //Mouse follow behavior
        if (mainCam != null)
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = mainCam.transform.position.y;
            mousePosition = mainCam.ScreenToWorldPoint(mousePosition);
            transform.position = Vector3.Lerp(transform.position, mousePosition, lerpSpeed * Time.deltaTime);
        }

    }
}
