using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimManager : MonoBehaviour
{

    public sigaba sim;

    int keystrokes;

    // Start is called before the first frame update
    void Start()
    {
        //sim = (sigaba) gameObject.GetComponent("sigaba");
        keystrokes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyPress(char key)
    {
        keystrokes++;
        sim.RotateRotor8();
         if(keystrokes%26 == 0){
         sim.RotateRotor7(); 
         }
         if(keystrokes%676 == 0){
         sim.RotateRotor9();
        }
        //print(keystrokes);
        // handle key press
        sim.UpdateRotors();
        char result = sim.Encrypt(key);
        //print(result);
    }

}
