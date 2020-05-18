using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{

    GameObject textbubble;

    void Start()
    {
        


        textbubble = new GameObject("textBubble");
        Vector3 pos = new Vector3(3.5f, 0f, -1f);
        Vector3 scale = new Vector3(0.2f, 0.2f, 1f);
        //scale 0.2 0.2 1

        var sr = textbubble.AddComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>("textbubble");

        textbubble.transform.position = pos;
        textbubble.transform.localScale = scale;


      
    }
}
