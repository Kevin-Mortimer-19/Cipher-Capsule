using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxManager : MonoBehaviour
{

    public GameObject info_box_1;
    public GameObject info_box_2;
    public GameObject info_box_3;
    public GameObject info_box_4;
    public GameObject info_box_5;
    public GameObject info_box_6;
    public GameObject info_box_7;
    public GameObject info_box_8;
    public GameObject info_box_9;
    public GameObject info_box_10;
    public GameObject info_box_11;
    public GameObject info_box_12;
    public GameObject info_box_13;
    public GameObject info_box_14;

    GameObject[] info_boxes = new GameObject[14];

    public Button next_button;

    public Button previous_button;

    int currently_selected;

    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        info_boxes[0] = info_box_1;
        info_boxes[1] = info_box_2;
        info_boxes[2] = info_box_3;
        info_boxes[3] = info_box_4;
        info_boxes[4] = info_box_5;
        info_boxes[5] = info_box_6;
        info_boxes[6] = info_box_7;
        info_boxes[7] = info_box_8;
        info_boxes[8] = info_box_9;
        info_boxes[9] = info_box_10;
        info_boxes[10] = info_box_11;
        info_boxes[11] = info_box_12;
        info_boxes[12] = info_box_13;
        info_boxes[13] = info_box_14;

        currently_selected = 0;
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextButton()
    {
        info_boxes[currently_selected].SetActive(false);
        currently_selected = Next(currently_selected);
        info_boxes[currently_selected].SetActive(true);
    }

    public void PreviousButton()
    {
        info_boxes[currently_selected].SetActive(false);
        currently_selected = Previous(currently_selected);
        info_boxes[currently_selected].SetActive(true);
    }

    int Next(int current)
    {
        int next = current + 1;
        if(next == 14)
        {
            next = 0;
        }
        return next;
    }

    int Previous(int current)
    {
        int next = current - 1;
        if(next == -1)
        {
            next = 13;
        }
        return next;
    }

    void Activate()
    {
        info_boxes[currently_selected].SetActive(true);
        next_button.gameObject.SetActive(true);
        previous_button.gameObject.SetActive(true);
        isActive = true;
    }

    void Deactivate()
    {
        info_boxes[currently_selected].SetActive(false);
        next_button.gameObject.SetActive(false);
        previous_button.gameObject.SetActive(false);
        isActive = false;
    }

    public void VisibilityButton()
    {
         if(isActive)
        {
            Deactivate();
            
        }
        else
        {
            Activate();
        }
    }

}
