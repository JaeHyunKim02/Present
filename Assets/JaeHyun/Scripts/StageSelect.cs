using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    [SerializeField]
    Text text;

    int temp;

    private void Start()
    {
        temp = PlayerPrefs.GetInt("StageNum");
        
    }


    private void Update()
    {
        text.text = PlayerPrefs.GetInt("StageNum").ToString();

    }
    public void StageNumUp()
    {
        if (temp >= PlayerPrefs.GetInt("StageNum"))
        {

        }
        else temp += 1;

    }

    public void StageNumDown()
    {
        if (temp <= 0)
        {

        }
        else temp -= 1;
    }
}
