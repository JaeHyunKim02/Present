using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum STATE
{
    ONE = 1,
    TWO,
    THREE,
    FORE,

}
public class Pipe : MonoBehaviour
{
    [SerializeField]
    STATE m_state;
    [SerializeField]
    STATE ClearState;

    public bool IsClear;

    // Start is called before the first frame update
    void Start()
    {
        IsClear = false;
        m_state = STATE.ONE;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.tag == ("I"))
        {
            Debug.Log("I임?");
            if (m_state == STATE.FORE)
                m_state = STATE.TWO;
            else if (m_state == STATE.THREE)
                m_state = STATE.ONE;
        }
        if (m_state == ClearState)
            IsClear = true;
        else
            IsClear = false;
    }
    public void Turn()
    {
        switch (m_state)
        {
            case STATE.ONE:
                gameObject.transform.Rotate(new Vector3(0, 0, 90));
                m_state += 1;
                break;
            case STATE.TWO:
                gameObject.transform.Rotate(new Vector3(0, 0, 90));
                m_state += 1;
                break;
            case STATE.THREE:
                gameObject.transform.Rotate(new Vector3(0, 0, 90));
                m_state += 1;
                break;
            case STATE.FORE:
                gameObject.transform.Rotate(new Vector3(0, 0, 90));
                m_state = STATE.ONE;
                break;
        }
    }
}