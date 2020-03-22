using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultWindow : MonoBehaviour
{
    public void GoNext()
    {
        Managers.Instance.gameManger.isNext = true;
    }
}
