using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public GameObject tutorial;

    bool isActive;

    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
        if(isActive)
        {
            tutorial.SetActive(false);
            isActive = false;
        }
        else
        {
            tutorial.SetActive(true);
            isActive = true;
        }
    }
}
