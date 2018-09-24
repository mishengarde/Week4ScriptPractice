using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatedog : MonoBehaviour
{
    public void Rotate(float sliderValue)
    {
        transform.eulerAngles = new Vector3(0, 0, sliderValue);
    }

}

