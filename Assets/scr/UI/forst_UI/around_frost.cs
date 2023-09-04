using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class around_frost : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sh_forst2_UI;
    public GameObject hid_forst_UI;
    void Start()
    {
        sh_forst2_UI.SetActive(false);
        hid_forst_UI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ch_UI(){
        hid_forst_UI.SetActive(false);
        sh_forst2_UI.SetActive(true);
    }
}
