using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEDDYBEAR : MonoBehaviour
{
    public float rotate_spd = 100.0f;
    public bool isClear = false;
    public GameObject teddyBear;

    void OnMouseDrag()
    {
        if (!isClear)
        {
            float temp_y_axis = Input.GetAxis("Mouse Y") * rotate_spd * Time.deltaTime;
            transform.Rotate(temp_y_axis, 0, 0, Space.World);
        }
    }

    private void Update()
    {
        if(Mathf.Abs(this.transform.rotation.x) >= 0.69f)
        {
            isClear = true;
            teddyBear.SetActive(true);
            StartCoroutine(IsClear());
        }
    }

    IEnumerator IsClear()
    {
        yield return new WaitForSeconds(2);
        Managers.Instance.gameManger.isClear = true;
    }
}
