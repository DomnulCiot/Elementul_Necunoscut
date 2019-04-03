using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_Answer : MonoBehaviour {
    public int answer;
    public Question_Manager qm;
    public Move_Var var;
    public Image img;
    public Button button;
    public Text text_Button;
    public Button btn1, btn2, btn3, btn4;
    public FeedBack_btn FB; 
    public void Check()
    {
        if (qm.questions[var.var_prim-1].answer == answer)
        {
            img.color = new Color(0.1019f, 0.9647f, 0.0235f, 0.4627f);
            button.interactable = true;
            //if (Move_Var.var < 4)
                text_Button.text = "NEXT";
           // else
               // text_Button.text = "MENU";
            text_Button.color = new Color (0f, 0f, 0f, 1f);
            btn1.interactable = false;
            btn2.interactable = false;
            btn3.interactable = false;
            btn4.interactable = false;
            FB.contor = true;
            FeedBack_btn.Done[Move_Var.var] = true;


        }
        else
        {
            img.color = new Color(0.9607f, 0.0274f, 0.0901f, 0.6627f);
            button.interactable = true;
            text_Button.text = "RETRY";
            text_Button.color = new Color(0f, 0f, 0f, 1f);
            btn1.interactable = false;
            btn2.interactable = false;
            btn3.interactable = false;
            btn4.interactable = false;
            FB.contor = false;
        }
    }
}
