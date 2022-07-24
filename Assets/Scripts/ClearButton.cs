using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearButton : MonoBehaviour
{
    public ButtonController other_btn;

    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
        other_btn.Clear();
    }
}
