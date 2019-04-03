using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizII_Control : MonoBehaviour {

    public InputField IF;
    public int answer;
    public Text Question_Text;
    public Question[] question;
    public Image img;
    public Button FeedBack_Button;
    public Text text_button;
    public GameObject GO;

    void Start ()
    {
        IF.ActivateInputField();
        Question_Text.text = question[Move_Var.var2-1].Q;
    }
    public void Submit ()
    {
        Debug.Log(IF.text);

        if (IF.text!="")
        {
               answer=int.Parse(IF.text);
               Debug.Log(answer);
               CheckAnswer();
        }
        
    }

    void CheckAnswer()
    {
        if (answer==question[Move_Var.var2-1].answer)
        {
            img.color = new Color(0.1019f, 0.9647f, 0.0235f, 0.4627f);
            GO.SetActive(false);
            FeedBack_Button.interactable = true;
            text_button.text = "NEXT";

        }
        else
        {
            img.color = new Color(0.9607f, 0.0274f, 0.0901f, 0.6627f);
            GO.SetActive(false);
            FeedBack_Button.interactable = true;
            text_button.text = "RETRY";
        }
    }


}
