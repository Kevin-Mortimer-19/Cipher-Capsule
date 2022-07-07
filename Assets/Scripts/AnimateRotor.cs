using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRotor : MonoBehaviour
{

    [SerializeField] private bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            Rotate();
        }
    }

    void Rotate()
    {
        transform.Rotate(new Vector3(0f, -50f, 0f) * Time.deltaTime);
    }

}
