using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekCounter : MonoBehaviour
{
    public Text counter;
    float currentweek = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentweek += 1 * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            changeWeeks();
        }
        counter.text = currentweek.ToString("0") + " weeks";
    }
    void changeWeeks(){
        currentweek = 1f;
    }
}
