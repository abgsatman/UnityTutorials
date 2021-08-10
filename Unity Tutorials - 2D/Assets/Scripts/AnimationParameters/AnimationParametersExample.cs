using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationParametersExample : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        animator.SetBool("Idle", false);
    }

    private void Update()
    {
        if(Input.GetKey("s")) //for stopping
        {
            animator.SetBool("Idle", false);
        }

        if(Input.GetKey("r")) //for running
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
            animator.SetBool("Idle", true);
        }
    }
}
