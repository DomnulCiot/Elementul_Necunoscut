using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Var : MonoBehaviour {

   public Button_prop prop;
    public static int var;
    public int var_prim;
    public static int var2;
    public static int inddex;
    private int cont1 = 0, cont2 = 0;

    void Start ()
    {
        var_prim = var;

    }
    public void move ()
    {
        inddex = prop.Index;
        FeedBack_btn.x = inddex;
        cont1 = 0;
        cont2 = 0;
        for (int i=1; i<=inddex; i++)
        {
            if (FeedBack_btn.Level[i - 1] == 1)
                cont1++;
            if (FeedBack_btn.Level[i - 1] == 2)
                cont2++;
            var = cont1;
            var2 = cont2;
        }
    }
	
}
