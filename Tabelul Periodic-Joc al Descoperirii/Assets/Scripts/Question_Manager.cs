using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question_Manager : MonoBehaviour {

    public Question[] questions;
    public Text text;
    public Move_Var var;
    void Start ()
    {
        text.text = questions[Move_Var.var-1].Q;
    }
}
