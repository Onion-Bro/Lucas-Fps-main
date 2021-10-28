using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADSCam : MonoBehaviour
{
    public GameObject Camera;
    public GameObject MainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Camera.SetActive(true);
            MainCamera.SetActive(false);
        }

        else
        {
            Camera.SetActive(false);
            MainCamera.SetActive(true);
        }


    }
}
