using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour {

    public answers_class[] answers;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
	void Start () {
        text1.text = answers[Move_Var.var-1].A1;
        text2.text = answers[Move_Var.var - 1].A2;
        text3.text = answers[Move_Var.var - 1].A3;
        text4.text = answers[Move_Var.var - 1].A4;
	}
}
