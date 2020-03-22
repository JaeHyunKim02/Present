using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers Instance;

    public GameManager gameManger;

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
    }
}
