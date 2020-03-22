using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Credit;

    [SerializeField]
    private bool IsCreditOpen = false;

    public GameObject[] btns;

    private void Start()
    {
        for(int i = 0; i < MyStatic.nowStage; i++)
        {
            btns[i].SetActive(true);
        }
        PlayerPrefs.SetInt("StageNum", default);
    }
    public void CreditOnOff()
    {
        if (!IsCreditOpen)
        {
            Credit.SetActive(true);
            IsCreditOpen = false;

        }
        else if(IsCreditOpen)
        {
            Credit.SetActive(false);
            IsCreditOpen = true;
        }

    }

    public void SceneChange()
    {
        SceneManager.LoadScene(MyStatic.nowStage + 1);
    }

    public void SceneChange(int i)
    {
        SceneManager.LoadScene(i);
    }
}
