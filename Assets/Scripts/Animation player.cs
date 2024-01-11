using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Animationplayer : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Space].wasPressedThisFrame)
        {
            Debug.Log("Pressed space");
            animator.SetTrigger("isRunning");
        }
        else
        {
        }
    }
}
