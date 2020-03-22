using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    int PipeCount;

    [SerializeField]
    Pipe[] Pipe;
    private void Awake()
    {
        for(int i=0;i<28;i++)
        {
            
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool IsClear = false;
        for (int i = 0; i < Pipe.Length; i++)
        {
            IsClear = Pipe[i].IsClear;
            if (!IsClear)
                break;
        }
        if (IsClear)
            Managers.Instance.gameManger.isClear = true;

    }

}
