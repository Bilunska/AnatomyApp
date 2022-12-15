using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidneyAnimation : MonoBehaviour
{
   private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimRotate(){
        Anim.Play("RotateKidney", -1, 0f);
        Anim.speed = 0.2f;
    }
}
