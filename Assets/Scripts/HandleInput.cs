using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void displayText(string textInField)
    {
        print(textInField);
    }
}
