using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtChoices : MonoBehaviour
{
    public Text behaviourText;
    int b1;
    int b2;
    int b3;
    float counter = 0f;
    int nextscenario = 1;
    bool count = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == true){
            counter += 1 * Time.deltaTime;
        }
        b1 = Random.Range(1, 3);
        b2 = Random.Range(3, 5);
        b3 = Random.Range(5, 7);
        /*Debug.Log("b1: "+b1);
        Debug.Log("b2: "+b2);
        Debug.Log("b3: "+b3);*/
        if (nextscenario == 1){
            if (Input.GetKeyDown(KeyCode.UpArrow)){
                textToUseChowder();
                Debug.Log("b1: " + b1);
            }
        }
        else if (nextscenario == 2){
            if (Input.GetKeyDown(KeyCode.UpArrow)){
                textToUseJohnnyTest();
                Debug.Log("b2: " + b2);
            }
        }
        else if (nextscenario == 3){
            if (Input.GetKeyDown(KeyCode.UpArrow)){
                textToUseFlapJack();
                Debug.Log("b3: " + b3);
            }
        }
    }

    void textToUseChowder(){
        var behaviour1 = Resources.Load<UnityEngine.UI.Text>("ChowderBad");
        var behaviour2 = Resources.Load<UnityEngine.UI.Text>("ChowderGood");
        var behaviour3 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestBad");
        var behaviour4 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestGood");
        var behaviour5 = Resources.Load<UnityEngine.UI.Text>("FlapJackBad");
        var behaviour6 = Resources.Load<UnityEngine.UI.Text>("FlapJackGood");
        count = true;

        if (b1 == 1){
            behaviourText.text = behaviour1.text;
            if (counter >= 30){
                nextscenario = 2;
                counter = 0f;
            }
        }
        if (b1 == 2){
            behaviourText.text = behaviour2.text;
            if (counter >= 30){
                nextscenario = 2;
                counter = 0f;
            }
        }
    }
    void textToUseJohnnyTest(){
        var behaviour1 = Resources.Load<UnityEngine.UI.Text>("ChowderBad");
        var behaviour2 = Resources.Load<UnityEngine.UI.Text>("ChowderGood");
        var behaviour3 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestBad");
        var behaviour4 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestGood");
        var behaviour5 = Resources.Load<UnityEngine.UI.Text>("FlapJackBad");
        var behaviour6 = Resources.Load<UnityEngine.UI.Text>("FlapJackGood");

        if (b2 == 3){
            behaviourText.text = behaviour3.text;
            if (counter >= 30){
                nextscenario = 3;
                counter = 0f;
            }
        }
        if (b2 == 4){
            behaviourText.text = behaviour4.text;
            if (counter >= 30){
                nextscenario = 3;
                counter = 0f;
            }
        }
    }
    void textToUseFlapJack(){
        var behaviour1 = Resources.Load<UnityEngine.UI.Text>("ChowderBad");
        var behaviour2 = Resources.Load<UnityEngine.UI.Text>("ChowderGood");
        var behaviour3 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestBad");
        var behaviour4 = Resources.Load<UnityEngine.UI.Text>("JohnnyTestGood");
        var behaviour5 = Resources.Load<UnityEngine.UI.Text>("FlapJackBad");
        var behaviour6 = Resources.Load<UnityEngine.UI.Text>("FlapJackGood");

        if (b3 == 5){
            behaviourText.text = behaviour5.text;
            if (counter >= 30){
                nextscenario = 1;
                counter = 0f;
            }
        }
        if (b3 == 6){
            behaviourText.text = behaviour6.text;
            if (counter >= 30){
                nextscenario = 1;
                counter = 0f;
            }
        }
    }
}
