using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance;
    public int nowStage;

    void Init()
    {
        if (Instance != null)
            Destroy(gameObject);

        Instance = this;
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Init();
        DontDestroyOnLoad(this.gameObject);
    }
}
