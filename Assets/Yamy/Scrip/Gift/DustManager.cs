using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DustManager : MonoBehaviour
{
    public Dust[] dusts; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool bTemp = false;
        for (int i = 0; i < dusts.Length; i++)
        {
            bTemp = !dusts[i].gameObject.GetComponent<Button>().enabled;
            if (!bTemp)
                break;
        }

        if(bTemp)
        {
            MyStatic.SceneName = "BoxRibbonScene";
            StartCoroutine(IsClear());
            Debug.Log("Clear");
        }
    }
    IEnumerator IsClear()
    {
        yield return new WaitForSeconds(1);
        Managers.Instance.gameManger.isClear = true;
    }
}
