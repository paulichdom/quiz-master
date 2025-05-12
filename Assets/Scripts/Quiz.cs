using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSo question;
    void Start()
    {
        questionText.text = question.GetQuestion();
    }
}
