using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVideo : MonoBehaviour
{

    int chooser = 1;
    Rigidbody2D rb;
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        //var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        //var gr = GetComponent<Resources>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            changevideoclip();
        }
    }
    void changevideoclip(){
        var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        var chooseCartoon1 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon1");
        var chooseCartoon2 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon2");
        var chooseCartoon3 = Resources.Load<UnityEngine.Video.VideoClip>("Cartoon3");

        if (chooser == 1){
            videoPlayer.clip = chooseCartoon1;
            chooser = 2;
            Debug.Log(chooser);
        }
        else if (chooser == 2){
            videoPlayer.clip = chooseCartoon2;
            chooser = 3;
            Debug.Log(chooser);
        }
        else if (chooser == 3)
        {
            videoPlayer.clip = chooseCartoon3;
            chooser = 1;
            Debug.Log(chooser);
        }
    }
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
