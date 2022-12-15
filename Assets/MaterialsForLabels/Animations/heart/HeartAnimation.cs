using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAnimation : MonoBehaviour
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
    
    public void AnimScale(){
        Anim.Play("ScaleHeart", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimRotate(){
        Anim.Play("RotateHeart", -1, 0f);
        Anim.speed = 0.2f;
    }
    
    public void AnimBack(){
        Anim.Play("HeartBack", -1, 0f);
        Anim.speed = 1f;
    }
}
