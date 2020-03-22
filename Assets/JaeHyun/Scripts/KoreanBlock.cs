using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KoreanBlock : MonoBehaviour
{
    [SerializeField]
    private Text text;

    [SerializeField]
    private string Letter;

    private void Awake()
    {
        text = gameObject.GetComponentInChildren<Text>();
        text.text = Letter;

    }
}
