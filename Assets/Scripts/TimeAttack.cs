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
                TimeSetUI.text = "남은시간: " + Min + "분" + (int)Sec + "초";
            }
            if (SetTime < 60f)
            {
                TimeSetUI.text = "남은시간:" + (int)SetTime + "초";
            }
            if (SetTime <= 0)
            {
                TimeSetUI.text = "남은시간 : 0초";
            }
        }

    }
}

