using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public static VideoClip videoClip;
    public VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Start()
    {
        if (videoClip == null)
        {
            Debug.Log("Pas de vidéo pour vous!");
        }
        else
        {
            videoPlayer.Play();
        }
    }
}