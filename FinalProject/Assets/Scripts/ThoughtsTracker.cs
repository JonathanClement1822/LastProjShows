using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtsTracker : MonoBehaviour
{
    int b1;

    GameObject textbubble;

    /*string ChowderBad = "Getting what I want is always important";
    string ChowderGood = "Listening to instructions is actually good";
    string JohnnyTestBad = "Not listening is funny";
    string JohnnyTestGood = "Not listening can upset my mom and dad";
    string FlapJackBad = "I can take whatever I want";
    string FlapJackGood = "Return things because it makes people happy";*/

    public Text behaviour;
    GameObject behaviourText;


    // Start is called before the first frame update
    void Start()
    {
        


        textbubble = new GameObject("textBubble");
        Vector3 pos = new Vector3(3f, 0f, -3f);
        Vector3 scale = new Vector3(0.2f, 0.2f, 1f);
        //scale 0.2 0.2 1

        var sr = textbubble.AddComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>("textbubble");

        textbubble.transform.position = pos;
        textbubble.transform.localScale = scale;


        //behaviour = new GameObject("text");
        var behaviour1 = Resources.Load<UnityEngine.UI.Text>("ChowderBad");
        var behaviour2 = Resources.Load<UnityEngine.UI.Text>("ChowderGood");
        var behaviour3 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestBad");
        var behaviour4 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestGood");
        var behaviour5 = Resources.Load<UnityEngine.UI.Text>("FlapJackBad");
        var behaviour6 = Resources.Load<UnityEngine.UI.Text>("FlapJackGood");

        Debug.Log(behaviour1.text);


        behaviourText = new GameObject("BehaviourText");
        behaviourText.transform.SetParent(textbubble.transform);
 
        Text myText = behaviourText.AddComponent<Text>();
        myText.text = behaviour1.text;

    }

    // Update is called once per frame
    void Update()
    {
       b1 = Random.Range(1, 2);
       if (Input.GetKeyDown(KeyCode.UpArrow)){
            textToUse();
        }
    }
    void textToUse(){
       /* var behaviour1 = Resources.Load<UnityEngine.UI.Text>("ChowderBad");
        var behaviour2 = Resources.Load<UnityEngine.UI.Text>("ChowderGood");
        var behaviour3 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestBad");
        var behaviour4 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestGood");
        var behaviour5 = Resources.Load<UnityEngine.UI.Text>("FlapJackBad");
        var behaviour6 = Resources.Load<UnityEngine.UI.Text>("FlapJackGood");

        if (b1 == 1){
            myText.text = behaviour1.text;
        }
        if (b1 == 2){
            myText.text = behaviour2.text;
        }*/
    }
}
