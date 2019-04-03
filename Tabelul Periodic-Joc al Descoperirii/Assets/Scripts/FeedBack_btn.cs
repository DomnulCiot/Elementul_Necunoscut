using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBack_btn : MonoBehaviour {

    public Check_Answer ChAs;
    public Fader fader;
    public bool contor;
    public static bool[] Done = new bool[]
        {
            false,false,false,false,false
        };
    public static int[] Level = new int[]
    {
        1,1,1,1,2
    };
public int x;

    // Use this for initialization
    void Start ()
{
    x = Move_Var.inddex;
}
    public void DoStuff ()
    {
        if (contor==true)
        {
            if (x < 118)
            {
            x++;
            if (Level[x] == 1)
                Move_Var.var++;
            else
                Move_Var.var2++;
                fader.Scene("Quiz");
            }
            else
            {
                fader.Scene("Levels");
            }
           
        }
        else
        {
            fader.Scene("Quiz");
        }
            
    }
}
