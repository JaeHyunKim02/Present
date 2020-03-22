using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isClear = false;
    public bool isNext = false;

    public ResultWindow resultWindow;

    public bool goHome = false;
    AsyncOperation ao;

    private void Start()
    {
        ao = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        ao.allowSceneActivation = false;
    }

    private void Update()
    {
        if(isClear)
        {
            resultWindow.gameObject.SetActive(true);
        }
        if (isNext)
        {
            if (ao.progress >= 0.9f)
            {
                MyStatic.nowStage += 1;
                Debug.Log(MyStatic.nowStage);
                ao.allowSceneActivation = true;
            }
        }
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
}