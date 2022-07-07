using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject focus;

    [SerializeField] private int camera_speed;

    [SerializeField] private float zoom_speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyPress();
    }


    // This function is dependent on deltaTime values, so if the future pause function freezes the timescale, this function will need to be revised

    void HandleKeyPress()
    {
        transform.LookAt(focus.transform);
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * zoom_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(Vector3.back * zoom_speed * Time.deltaTime);
        }
    }

}
