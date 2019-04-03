using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Fader : MonoBehaviour {

    public Image img;
    public float speed;
    public AnimationCurve curve;
    
    void Start ()
    {
        StartCoroutine(FadeIn());
    }
    public void Scene (string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

    IEnumerator FadeIn()
    {
        float time = 1f;
         while (time>0)
        {
            time -= Time.deltaTime * speed ;
            float a = curve.Evaluate(time);
            img.color = new Color (0.4039f, 0.0196f, 0.7490f ,a);
            yield return 0;
        }
    }

    IEnumerator FadeOut(string scene)
    {
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime * speed;
            float a = curve.Evaluate(time);
            img.color = new Color(0.4039f, 0.0196f, 0.7490f, a);
            yield return 0;
        }

        SceneManager.LoadScene(scene);

    }

}
