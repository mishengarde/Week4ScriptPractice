using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    public Rigidbody RemainsCylinder;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            //Rigidbody clone;
            //clone = Instantiate(RemainsCylinder, transform.position, transform.rotation) as Rigidbody;
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
