using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TicketInteraction : MonoBehaviour
{
    private VideoPlayer _interactorVideo;


    private void Awake()
    {
        _interactorVideo             = GetComponentInChildren<VideoPlayer>();
        _interactorVideo.isLooping   = false;
        _interactorVideo.playOnAwake = false;
    }

    public void PlayVideo()
    {
        Debug.Log("play video");
        _interactorVideo.Play();
    }
}
