using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabel_Manager : MonoBehaviour {

    public Button[] button;

    public GameObject pan;
    void Start ()
    {
        for (int i = 0; i <= 118; i++)
            if (FeedBack_btn.Done[i] == true)
                Unlock(i);
    }
    void Unlock (int nr)
    {
  
        button[nr].interactable = true;
    }

    public void Close()
    {
        pan.SetActive(false);
    }


}
