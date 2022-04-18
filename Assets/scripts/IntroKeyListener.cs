using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroKeyListener : MonoBehaviour
{
    private Animator Intro;
    public GameObject MenuCanvas;

    private void Start()
    {
        Intro = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Intro.SetBool("IntroOut",true);
        }
        
    }
    void IntroDeactivate()
    {
        MenuCanvas.SetActive(true);
        Object.Destroy(gameObject);

    }
}
