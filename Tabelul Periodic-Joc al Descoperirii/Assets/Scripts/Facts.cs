using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Facts : MonoBehaviour {

    public Text text1;
    public Text text2;
    public Element_Class[] E_C;
    public int var1;

    public void Text_Gen ()
    {
        text1.text = E_C[var1-1].S1;
        text2.text = E_C[var1-1].S2;
    }

}
