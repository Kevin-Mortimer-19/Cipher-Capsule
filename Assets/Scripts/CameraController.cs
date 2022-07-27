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

    bool default_view;

    bool tooClose;

    bool tooFar;

    // Start is called before the first frame update
    void Start()
    {
        camera_vert_speed = camera_speed / 4;
        default_view = true;
        CameraStateCheck();
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
        float d = Vector3.Distance(transform.position, focus.transform.position);

        if(d > 10)
        {
            tooFar = true;
        }
        else if(d < 2)
        {
            tooClose = true;
        }
        else
        {
            CameraStateCheck();
        }

        if(default_view)
        {
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
                transform.LookAt(focus.transform);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * camera_vert_speed * Time.deltaTime);
                transform.LookAt(focus.transform);
            }
            if (Input.GetKey(KeyCode.Tab) && !tooClose)
            {
                transform.Translate(Vector3.forward * zoom_speed * Time.deltaTime);
                transform.LookAt(focus.transform);
            }
            if (Input.GetKey(KeyCode.LeftShift) && !tooFar)
            {
                transform.Translate(Vector3.back * zoom_speed * Time.deltaTime);
                transform.LookAt(focus.transform);
            }
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

    public void KeyboardPerspective()
    {
        transform.position = new Vector3(2.5f, 4f, 2.5f);
        transform.rotation = Quaternion.Euler(90, 90, 0);
        default_view = false;
    }

    public void RotorPerspective()
    {
        transform.position = new Vector3(5.75f, 6.75f, 4.75f);
        transform.rotation = Quaternion.Euler(60, 180, 0);
        default_view = false;
    }

    public void DefaultPerspective()
    {
        transform.position = new Vector3(-3f, 2f, 3f);
        transform.rotation = Quaternion.Euler(0, 90, 0);
        default_view = true;
        transform.LookAt(focus.transform);
        CameraStateCheck();
    }

    void CameraStateCheck(){
        tooClose = false;
        tooFar = false;
    }
}