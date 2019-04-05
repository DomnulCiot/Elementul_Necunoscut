using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_prop : MonoBehaviour
{
    public int Index;
    public Button button;
    public Text text;
    public int contor;
    public Color NewColor2;
    //public int numb_question ;
    public Fader fader;
    void Start()
    {
        button = this.button;
         /*if (Index > 5)
         {
             ColorBlock cb = button.colors;
             cb.disabledColor = newColor;
             button.interactable = false;
             button.colors = cb;

         }
         else*/
             if (Index<=118)
             if (FeedBack_btn.Done[Index-1]==true)
             {
                 ColorBlock cb = button.colors;
                 cb.normalColor = NewColor2;
                 button.colors = cb;
             }

       

        text.text = Index.ToString();
    }
    public void Quiz ()
    {
        {
           // numb_question = Index;
            if (contor==1)
            fader.Scene("Quiz");
            if (contor == 2)
                fader.Scene("Quiz II");
        }
    }


}
