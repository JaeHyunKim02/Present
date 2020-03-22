using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [SerializeField]
    Text[] text;

    [SerializeField]
    int Count;

    public GameObject gift;
    // Start is called before the first frame update
    void Start()
    {
        text[0].text = "너가  최고야";
        text[1].text = "너라서 멋있어";
        text[2].text = "너라서 예뻐";
        text[3].text = "잘 못해도 돼 ";
        text[4].text = "너가 제일 중요해";
        text[5].text = "사랑해";
        text[6].text = "너 자체가 선물이야";

        Count = -1;
    }

    public void isTouching()
    {
        if (Count >= 6)
        {
            Color c = this.GetComponent<Image>().color;
            c.a = 0.0f;
            this.GetComponent<Image>().color = c;
            gift.SetActive(true);
            StartCoroutine(IsClear());
        }
        Vector3 v = new Vector3(0.6f, 0.6f, 0);
        this.GetComponent<RectTransform>().localScale += v;
        Count += 1;
        text[Count].gameObject.SetActive(true);
    }

    IEnumerator IsClear()
    {
        yield return new WaitForSeconds(2);
        Managers.Instance.gameManger.isClear = true;
    }
}
