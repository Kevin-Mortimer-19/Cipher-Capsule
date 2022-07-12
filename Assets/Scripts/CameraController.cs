using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject focus;

    [SerializeField] private int camera_speed;

    private int camera_vert_speed;

    public SimManager sim;

    [SerializeField] private int zoom_speed;

    // Start is called before the first frame update
    void Start()
    {
        camera_vert_speed = camera_speed / 2;
        //sim = (SimManager) gameObject.GetComponent("SimManager");
    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyPress();
        HandleClick();
    }


    // This function is dependent on deltaTime values, so if the future pause function freezes the timescale, this function will need to be revised

    void HandleKeyPress()
    {
        transform.LookAt(focus.transform);
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(Vector3.right * camera_speed * Time.deltaTime);
            transform.RotateAround(focus.transform.position, Vector3.down, camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left * camera_speed * Time.deltaTime);
            transform.RotateAround(focus.transform.position, Vector3.up, camera_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * camera_vert_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * camera_vert_speed * Time.deltaTime);
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

    void HandleClick()
    {
        if (Input.GetMouseButtonDown(0)){ // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                if(hit.collider != null)
                {
                    KeyPress key_script = (KeyPress) hit.collider.gameObject.GetComponent("KeyPress");
                    sim.KeyPress(key_script.key_value);
                }
            }
        }
    }
}