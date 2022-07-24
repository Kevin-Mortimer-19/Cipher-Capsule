using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator rotor1;
    public Animator rotor2;
    public Animator rotor3;
    public Animator rotor4;
    public Animator rotor5;
    public Animator rotor6;
    public Animator rotor7;
    public Animator rotor8;
    public Animator rotor9;
    public Animator rotor10;
    public Animator rotora;
    public Animator rotorb;
    public Animator rotorc;
    public Animator rotord;
    public Animator rotore;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spin(int spin_rotor)
    {
        switch(spin_rotor)
        {
            case 1:
                rotor1.SetTrigger("Start");
                break;
            case 2:
                rotor2.SetTrigger("Start");
                break;
            case 3:
                rotor3.SetTrigger("Start");
                break;
            case 4:
                rotor4.SetTrigger("Start");
                break;
            case 5:
                rotor5.SetTrigger("Start");
                break;
            case 6:
                rotor6.SetTrigger("Start");
                break;
            case 7:
                rotor7.SetTrigger("Start");
                break;
            case 8:
                rotor8.SetTrigger("Start");
                break;
            case 9:
                rotor9.SetTrigger("Start");
                break;
            case 10:
                rotor10.SetTrigger("Start");
                break;
        }
    }
}
