using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    public bool trueOrFalse;
    public float decimalNumber;
    private float speed = 100.0f;
    public string firstName = "Meeshel";
    public Transform RemainsCylinder;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Hello world");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(RemainsCylinder, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
