using System.Collections;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private Animator menuAnim;
    private bool menuOn = false;

    // Start is called before the first frame update
    void Awake()
    {
        menuAnim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    public void BeginMenu()
    {
        if(!menuOn){
            menuAnim.SetTrigger("FadeIn");
            menuOn = true;
        }
        else{
            menuAnim.SetTrigger("FadeOut");
            menuOn = false;
        }
    }
}
