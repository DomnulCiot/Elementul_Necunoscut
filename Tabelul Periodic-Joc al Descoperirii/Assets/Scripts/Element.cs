using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour {

    public int ord_numb;
    public GameObject pan;
    public Facts facts;
	
    public void Open ()
    {
        facts.var1 = ord_numb;
        pan.SetActive(true);
        facts.Text_Gen();

    }

}
