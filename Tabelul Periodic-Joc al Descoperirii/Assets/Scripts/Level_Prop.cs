using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Prop : MonoBehaviour {
    public int Index;
    public Button button;
    public Color newColor;
	void Start () {
        //Button button = gameObject.GetComponent(Button);
        if (Index > 5)
        {
            ColorBlock cb = button.colors;
            cb.disabledColor = newColor;
            button.interactable = false;
            button.colors = cb;
            
        }
	}
	
	
}
