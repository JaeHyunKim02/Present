using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block
{
    public Vector2 position;
    Text text;

}


public class WordSerch : MonoBehaviour
{
    [SerializeField]
    private GameObject[] BlockArr;


    string word;

    [SerializeField]
    Camera camera;

    RaycastHit2D hit;
    Vector3 MousePosition;

    [SerializeField]
    private Vector3 TempPos;


    bool IsClear = false;

    bool IsOne = true;
    Color Majenta;

    [SerializeField]
    private Text text;

    [SerializeField]
    private RectTransform testPos;

    [SerializeField]
    Color color;

    void Start()
    {
        BlockArr = GameObject.FindGameObjectsWithTag("Block");

        IsOne = true;
        Majenta = new Color(243, 165, 25);



    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = camera.ScreenToWorldPoint(MousePosition);
            hit = Physics2D.Raycast(MousePosition, transform.forward, 10);
            if (hit && IsOne)
            {
                testPos = hit.transform.GetComponent<RectTransform>();

                TempPos = hit.transform.position;
                IsOne = false;

            }
            /*
            MousePosition.x < (testPos.position.x*3)- (testPos.position.x/2) &&
            MousePosition.x > -((testPos.position.x * 3) - (testPos.position.x / 2)) &&
            MousePosition.y < (testPos.position.y * 3) - (testPos.position.y / 2) &&
            MousePosition.y > -((testPos.position.y * 3) - (testPos.position.y / 2)) &&
             */
            if (hit &&
                MousePosition.x < TempPos.x + 1 &&
                MousePosition.x > TempPos.x - 1 &&
                MousePosition.y < TempPos.y + 1 &&
                MousePosition.y > TempPos.y - 1 &&
                hit.transform.GetComponent<Image>().color != color)
            {

                word += hit.transform.GetComponentInChildren<Text>().text;
                hit.transform.GetComponent<Image>().color = color;
                TempPos = hit.transform.position;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            if (word == "PRESENT")
            {
                Debug.Log("클리어");

                Managers.Instance.gameManger.isClear = true;

            }
            else
            {
                for (int i = 0; i < BlockArr.Length; i++)
                {
                    BlockArr[i].GetComponent<Image>().color = new Color(255, 255, 255);
                }
                IsOne = true;
                TempPos = Vector3.zero;
                word = null;
                Debug.Log("클리어 실패");
            }

        }
        text.text = word;
    }

    #region 필요 없을듯
    //LANGUAGE SetLanguage;

    //[SerializeField]
    //private GameObject test;

    //private List<List<Block>> blockArr = new List<List<Block>>();
    //private List<List<GameObject>> blockObjList = new List<List<GameObject>>();
    //private float BlockSize =1.0f;

    //private void Start()
    //{
    //    InitPlate(10);
    //}
    //void InitPlate(int size)
    //{
    //    for(int i=0;i<size;i++)
    //    {
    //        blockArr.Add(new List<Block>());
    //        blockObjList.Add(new List<GameObject>());
    //        for (int j=0;j<size;j++)
    //        {


    //               Block temp = new Block();
    //            temp.position = transform.position + new Vector3(-3.9f, 3.9f) + new Vector3(i*BlockSize, j* BlockSize);

    //            //temp.position = transform.position + new Vector3(-3.9f, 3.9f);// + new Vector3(j * BlockSize, -i * BlockSize);

    //            blockArr[i].Add(temp);
    //            blockObjList[i].Add(null);

    //        }
    //    }
    //    for(int i=0; i<size;i++)
    //    {
    //        for(int j=0;j<size;j++)
    //        {

    //            blockObjList[i][j] = Instantiate(test, transform);
    //            blockObjList[i][j].transform.position = blockArr[i][j].position;
    //        }
    //    }
    //}
    #endregion
}
