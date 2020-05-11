using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class whitetored : MonoBehaviour
{
    public Image image;
    public float green;
    public float blue;

    void Update()
    {
        if (blue >= 255f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetMouseButtonDown(0))
        {
            blue = blue + 2f;
            green = green + 2f;
        }
        blue = blue - Time.deltaTime;
        green = green - Time.deltaTime;
        image = GetComponent<Image>();
        image.color = new Color(255f, green, blue, 255f);
/*        while (blue >= -1f && blue < 256f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                blue = blue + 2;
                green = green + 2;
            }
            else
            {
                blue = blue - Time.deltaTime;
                green = green - Time.deltaTime;
                image = GetComponent<Image>();
                image.color = new Color(255f, green, blue, 255f);
            }
        }*/
      

    }
}
