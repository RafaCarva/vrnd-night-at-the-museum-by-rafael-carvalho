using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class PlayPause : MonoBehaviour {

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void PlayPauseVideo()
    {
        if (videoPlayer.isPlaying){
            videoPlayer.Pause();
        }
        else
        {videoPlayer.Play();
        }
    }

}
