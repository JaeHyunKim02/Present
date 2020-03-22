using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibbonBoxManager : MonoBehaviour
{
    public bool boxTouched { get; set; }
    public bool ribbonTouched { get; set; }

    public GameObject ribbonBox;

    void Update()
    {
        if(boxTouched && ribbonTouched)
        {
            ribbonBox.SetActive(true);
            StartCoroutine(IsClear());
        }
    }

    IEnumerator IsClear()
    {
        yield return new WaitForSeconds(2);
        Managers.Instance.gameManger.isClear = true;
    }
}
