using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KoreanWordSerch : MonoBehaviour
{
    RaycastHit2D hit;
    [SerializeField]
    GameObject HitObject;

    Vector3 MousePosition;
    [SerializeField]
    Camera camera;

    [SerializeField]
    RectTransform Box1;

    [SerializeField]
    RectTransform Box2;

    bool IsClear1, IsClear2;

    Vector3 tempPos;
    GameObject tempObj;

    [SerializeField]
    private Animator animator;

    int count;

    private void Start()
    {
        count = 0;
        IsClear1 = false;
        IsClear2 = false;
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (count >= 2)
            Managers.Instance.gameManger.isClear = true;

        if (Input.GetMouseButtonDown(0) && !IsClear1 && !IsClear2)
        {
            MousePosition = Input.mousePosition;
            MousePosition = camera.ScreenToWorldPoint(MousePosition);
            hit = Physics2D.Raycast(MousePosition, transform.forward, Time.deltaTime);

            if (hit && hit.transform.GetComponentInChildren<Text>().text == "선")
            {
                // StartCoroutine(MoveText(hit.transform.position, Box1.position));
                tempPos = hit.transform.position;
                tempObj = hit.transform.gameObject;
                IsClear1 = true;

            }
            else if (hit && hit.transform.GetComponentInChildren<Text>().text == "물")
            {
                //hit.transform.position = Vector3.Lerp(hit.transform.position, Box2.position, Time.deltaTime*5f);
                tempPos = hit.transform.position;
                tempObj = hit.transform.gameObject;
                IsClear2 = true;
            }
            else if (hit)
            {
                Debug.Log("띠용");
                hit.transform.GetComponent<Animator>().Play("Ddiyoung");//gameObject.GetComponent<Animator>().Play("Ddiyoung");// animator.Play("Ddiyoung");
            }
        }

        if (IsClear1)
        {
            tempObj.transform.position = Vector3.Lerp(tempObj.transform.position, Box1.transform.position, Time.deltaTime * 5.0f);
            if (tempObj.transform.position == Box1.transform.position)

            {
                count += 1;
                IsClear1 = false;
            }
        }
        if (IsClear2)
        {
            tempObj.transform.position = Vector3.Lerp(tempObj.transform.position, Box2.transform.position, Time.deltaTime * 5.0f);
            if (tempObj.transform.position == Box2.transform.position)
            {
                count += 1;
                IsClear2 = false;
            }
        }
    }


}
