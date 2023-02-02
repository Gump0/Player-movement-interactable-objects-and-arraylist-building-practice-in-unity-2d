using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Torch : MonoBehaviour
{
    private Animator animator;
    void Awake()
    {
       animator = GetComponent<Animator>(); 
    }

    void OnSwitchChanged(bool isOn)
    {
        animator.SetBool("isOn", isOn);
    }
}
