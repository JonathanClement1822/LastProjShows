using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVideo : MonoBehaviour
{

    int chooser = 1;
    float currentTime = 0f;
    float startingTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= 1 * Time.deltaTime;
       // Debug.Log(currentTime);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            changevideoclip();
            currentTime = 10f;
        }
    }
    void changevideoclip(){
        //Get the componect from Unity Video player
        var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();

        //Load the different video clips 
        var chooseCartoon1 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon1");
        var chooseCartoon2 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon2");
        var chooseCartoon3 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon3");
        //int counter = 0;

        //The chooser starts as 1 so the first video is triggered
        //After the trigger, the chooser changing to 2 after the video reaches a certai frame
        if (chooser == 1){
            videoPlayer.clip = chooseCartoon1;
           // time();
            if (videoPlayer.frame >= 100){
                Debug.Log("Money");
                chooser = 2;
            }
            Debug.Log(chooser);
            //chooser = 2;
           // Debug.Log(chooser);

        }
        else if (chooser == 2){
            videoPlayer.clip = chooseCartoon2;
            if (videoPlayer.frame >= 100){
                Debug.Log("Money");
                chooser = 3;
            }
            Debug.Log(chooser);
        }
        else if (chooser == 3)
        {
            videoPlayer.clip = chooseCartoon3;
            if (videoPlayer.frame >= 100){
                Debug.Log("Money");
                chooser = 1;
            }
            Debug.Log(chooser);
        }
    }
    /*void time(){
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
    }*/
}
/*{
    public UnityEngine.Video.VideoClip videoClip;

    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var vp = GetComponent<UnityEngine.Video.VideoPlayer>();

            if (vp.isPlaying)
            {
                vp.Pause();
            }
            else
            {
                vp.Play();
            }
        }
    }
}*/
