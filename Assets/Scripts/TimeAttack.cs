using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttack : MonoBehaviour
{
    public static TimeAttack instace;

    public Text TimeSetUI;

    public bool TimeOut;
    
    float SetTime = 180;
 
    int Min;
    float Sec;
    
    void Start()
    {
        TimeAttack.instace = this;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeOut == true)
        {
            SetTime -= Time.deltaTime;

            if (SetTime >= 60f)
            {
                Min = (int)SetTime / 60;
                Sec = SetTime % 60;
                TimeSetUI.text = "�����ð�: " + Min + "��" + (int)Sec + "��";
            }
            if (SetTime < 60f)
            {
                TimeSetUI.text = "�����ð�:" + (int)SetTime + "��";
            }
            if (SetTime <= 0)
            {
                TimeSetUI.text = "�����ð� : 0��";
            }
        }

    }
}

