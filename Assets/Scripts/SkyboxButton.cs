using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyboxButton : MonoBehaviour
{


    public Material skybox_1;
    public Material skybox_2;
    public Material skybox_3;
    public Material skybox_4;

    Material[] skyboxes = new Material[4];

    public Button bg_button;

    int currently_selected;

    // Start is called before the first frame update
    void Start()
    {
        skyboxes[0] = skybox_1;
        skyboxes[1] = skybox_2;
        skyboxes[2] = skybox_3;
        skyboxes[3] = skybox_4;

        currently_selected = 0;

        bg_button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        currently_selected = Next(currently_selected);
        RenderSettings.skybox = skyboxes[currently_selected];

    }

    int Next(int current)
    {
        int next = current + 1;
        if(next == 4)
        {
            next = 0;
        }
        return next;
    }
}