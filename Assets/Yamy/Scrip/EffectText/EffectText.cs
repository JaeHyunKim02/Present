using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectText : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Color c = text.color;
        c.a -= 0.01f;
        text.color = c;
        Vector3 v = new Vector3(0.05f, 0.05f, 0);
        this.GetComponent<RectTransform>().localScale += v;
        if (text.color.a <= 0.0f)
            Destroy(gameObject);
    }
}
