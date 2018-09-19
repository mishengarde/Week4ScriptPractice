using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public float speed = 2.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 0, speed));


    }

    public void Jump(float force)
    {
        GetComponent<Rigidbody>().AddForce(0, force, 0);

    }

    public void Fade(float sliderValue)
    {
        materialColor.a = sliderValue;
        GetComponent<MeshRenderer>().materialColor =
    }

}
