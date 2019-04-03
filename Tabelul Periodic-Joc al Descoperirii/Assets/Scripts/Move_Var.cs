using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Var : MonoBehaviour {

   public Button_prop prop;
    public static int var;
    public int var_prim;
    public static int var2;
    public static int inddex;

    void Start ()
    {
        var_prim = var;

    }
    public void move ()
    {
        inddex = prop.Index;
        if (prop.contor==1)
        var = prop.numb_question;
        if (prop.contor == 2)
            var2 = prop.numb_question;
    }
	
}
