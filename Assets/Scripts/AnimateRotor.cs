using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRotor : MonoBehaviour
{

    public bool index_rotor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(index_rotor)
        {
            Rotate();
        }
    }

    void Rotate()
    {
        //transform.Rotate(new Vector3(0f, -50f, 0f) * Time.deltaTime);
    }

}
