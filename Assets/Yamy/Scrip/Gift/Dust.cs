using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dust : MonoBehaviour
{
    public bool isTouched = false;
    Vector3 pushVector;
    public int direction;

    public void Awake()
    {
        switch(direction)
        {
            case 0: pushVector = new Vector3(0.1f, 0.1f, 0); break;
            case 1: pushVector = new Vector3(0.1f, -0.1f, 0); break;
            case 2: pushVector = new Vector3(-0.1f, -0.1f, 0); break;
            case 3: pushVector = new Vector3(-0.1f, 0.1f, 0); break;
            case 4: pushVector = new Vector3(0, 0.1f, 0); break;
            case 5: pushVector = new Vector3(0, -0.1f, 0); break;
            case 6: pushVector = new Vector3(0.1f, 0, 0); break;
            case 7: pushVector = new Vector3(-0.1f, 0, 0); break;
        }
    }

    int pushCount = 0;

    private void Update()
    { 
        if (isTouched)
        {
            this.gameObject.transform.Translate(pushVector);
            pushCount++;
            if (pushCount == 10)
            {
                isTouched = false;
                pushCount = 0;
            }
        }
    }
    public void isTouching()
    {
        isTouched = true;
        this.gameObject.GetComponent<Button>().enabled = false;
    }
}
