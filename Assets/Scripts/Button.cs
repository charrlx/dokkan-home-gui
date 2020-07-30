using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] AudioClip blip;
    [SerializeField] AudioClip theme;
    [SerializeField] AudioClip swipe;
    public Animator anim;
    // Update is called once per frame
    void Start()
    {
        AudioHelper.PlayClip2D(theme, .1f);
    }

    public void PlayAudio()
    {
        AudioHelper.PlayClip2D(blip, 1f);
    }

    public void SwipeAudio()
    {
        AudioHelper.PlayClip2D(swipe, .5f);
    }

    public void PlayAnimation()
    {
        anim.Play("speed");
    }
}
