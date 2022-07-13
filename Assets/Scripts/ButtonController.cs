using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public GameObject e_out;

    public GameObject d_out;

    public SimManager sim;

    public Button btn;

    public sigaba machine;

    bool encrypt;

    public Text btext;
    // Start is called before the first frame update
    void Start()
    {
        encrypt = true;
        //Button btn = (Button) this.gameObject;
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
        sim.OutputReset();
		if(encrypt)
        {
            e_out.SetActive(false);            
            d_out.SetActive(true);
            btext.text = "Decrypt";
            encrypt = false;
            machine.ResetRotors();
        } else {
            e_out.SetActive(true);            
            d_out.SetActive(false);
            btext.text = "Encrypt";
            encrypt = true;
            machine.ResetRotors();
        }
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
