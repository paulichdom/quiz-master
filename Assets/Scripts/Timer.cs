using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeToShowCorrectAnswer = 10f;
    [SerializeField] float timeToCompleteQuestion = 30f;
    
    public bool isAsweringQuestion = false;
    private float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAsweringQuestion)
        {
            if (timerValue <= 0)
            {
                isAsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue <= 0)
            {
                isAsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }
        
        Debug.Log(timerValue);
    }
}
