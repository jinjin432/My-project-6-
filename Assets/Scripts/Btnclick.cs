using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btnclick : MonoBehaviour
{
    public int m_btnIndex = 0;

    public Button m_btn = null;

    public Text m_btnText = null;

    public void OnBtnClick()
    {
        if (m_btnIndex == 0) Debug.Log("�����");
        else if (m_btnIndex == 1) Debug.Log("������");
        else if (m_btnIndex == 2)
        {
            if (m_btnText.text == "����")
            {
                m_btnText.text = "¥��";   
            }

            else if (m_btnText.text == "¥��")
            {

                m_btnText.text = "����";
            }
        }
    }
}