using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light : MonoBehaviour
{
    float i = -0.005f;
    // Update is called once per frame
    void Update()
    {
        Color c = this.GetComponent<Image>().color;
        c.a += i;
        this.GetComponent<Image>().color = c;
        if (this.GetComponent<Image>().color.a <= 0.0f || this.GetComponent<Image>().color.a >= 1.0f)
            i = -i; 
    }
}
