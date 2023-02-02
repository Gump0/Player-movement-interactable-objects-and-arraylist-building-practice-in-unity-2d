using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator)),
RequireComponent(typeof(AudioSource))]

public class Switch : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    private bool isOn;

    public GameObject target;


    void Awake()
    {
       animator = GetComponent<Animator>();
       audioSource = GetComponent<AudioSource>(); 
    }

private void OnUse()
{
    isOn = !isOn;

    animator.SetBool("isOn", isOn);
    audioSource.Play();

    target.SendMessage("OnSwitchChanged", isOn);
}
}
