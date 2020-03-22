using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public bool isTouched;

    public void isTouching()
    {
        isTouched = true;
        Managers.Instance.gameManger.isClear = true;
    }
}