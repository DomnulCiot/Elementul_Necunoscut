using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_former : MonoBehaviour {

   public int index;
    public Text m_text;
    public Move_Var var;
	void Start () {
       
        m_text.text = index.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        index = var.var_prim;
        m_text.text = index.ToString();

    }
}
