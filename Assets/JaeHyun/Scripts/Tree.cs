using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject gift;
    public bool isClear { get; set; }

    // Update is called once per frame
    void Update()
    {
        if (isClear)
        {
            gift.SetActive(true);
            StartCoroutine(IsClear());
        }
    }

    IEnumerator IsClear()
    {
        yield return new WaitForSeconds(2);
        Managers.Instance.gameManger.isClear = true;
    }
}
