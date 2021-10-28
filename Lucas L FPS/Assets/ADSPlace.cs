using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADSPlace : MonoBehaviour
{
    public float LeftMove = 0.658f;
    public float BackMove = 0.14f;
    public float UpMove = 0.12f;
    public GameObject Crosshair;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Den flyttar vapnet
        if (Input.GetMouseButtonDown(1))
        {
            transform.Translate(Vector3.left * LeftMove);
            transform.Translate(Vector3.back * BackMove);
            transform.Translate(Vector3.up * UpMove);
           
            Crosshair.SetActive(false);
        }
        //Den flyttar tillbaka vapnet.
        if (Input.GetMouseButtonUp(1))
        {
            transform.Translate(Vector3.right * LeftMove);
            transform.Translate(Vector3.forward * BackMove);
            transform.Translate(Vector3.down * UpMove);
            Crosshair.SetActive(true);
        }

    }
}