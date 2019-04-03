using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabel_Manager : MonoBehaviour {

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public GameObject pan;
    void Start ()
    {
        for (int i = 0; i <= 4; i++)
            if (FeedBack_btn.Done[i] == true)
                Unlock(i);
    }
    void Unlock (int nr)
    {
        if (nr==1)
        button1.interactable = true;
        if (nr == 2)
            button2.interactable = true;
        if (nr == 3)
            button3.interactable = true;
        if (nr == 4)
            button4.interactable = true;
    }

    public void Close()
    {
        pan.SetActive(false);
    }


}
