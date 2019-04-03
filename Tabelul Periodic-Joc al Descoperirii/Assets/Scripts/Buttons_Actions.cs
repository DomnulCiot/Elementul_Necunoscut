using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons_Actions : MonoBehaviour {

    public Fader fader;
	public void Level_Change ()
    {
        fader.Scene("Levels");
    }
    public void Periodic_Tabel_Change ()
    {
        fader.Scene("Periodic Tabel");
    }
    public void Quit ()
    {
        Application.Quit();
    }
}
