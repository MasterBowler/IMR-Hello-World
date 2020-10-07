using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUnitychan : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isCameraClose", true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isCameraClose", false);
    }
}
