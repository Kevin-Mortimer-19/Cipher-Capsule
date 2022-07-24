using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardInput : MonoBehaviour
{

    public SimManager sim;

    public Toggle toggle;

    char lower_bound = 'a';

    char upper_bound = 'z';

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(toggle.isOn && Input.inputString != "")
        {
            char[] str = Input.inputString.ToCharArray();
            char c = str[0];
            if(c >= lower_bound && c <= upper_bound)
            {
                sim.KeyPress(c);
            }
        }
    }
}
