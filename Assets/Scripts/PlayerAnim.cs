using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator; // untuk animasi
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Animate(int action)
    {
        if (action == 1) animator.SetTrigger("Jump J");
        if (action == 2) animator.SetTrigger("Push Up");
        if (action == 3) animator.SetTrigger("Sit Up");
        if (action == 4) animator.SetTrigger("Cross Jump");
        if (action == 5) animator.SetTrigger("Kip Up");
        if (action == 6) animator.SetTrigger("Pistol");
        if (action == 7) animator.SetTrigger("Back Squat");
    }

}
