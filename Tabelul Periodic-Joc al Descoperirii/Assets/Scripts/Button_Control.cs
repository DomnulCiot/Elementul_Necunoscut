using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Control : MonoBehaviour {

    public Fader fader;

	public void Back ()
    {
        fader.Scene("Menu");
    }
    }

