using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeAnimation : MonoBehaviour
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
        Anim.Play("ScaleEye", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimRotate(){
        Anim.Play("RotateEye", -1, 0f);
        Anim.speed = 0.2f;
    }
    
    public void AnimBack(){
        Anim.Play("EyeBack", -1, 0f);
        Anim.speed = 1f;
    }
}
