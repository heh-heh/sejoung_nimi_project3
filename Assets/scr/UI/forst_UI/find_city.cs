using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class find_city : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject find_city_sh;
    public GameObject hid_forst;
    void Start()
    {
        find_city_sh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fid_city(){
        find_city_sh.SetActive(true);
        hid_forst.SetActive(false);
        back_ground_manager.back_ground_static[3].SetActive(false);
        back_ground_manager.back_ground_static[0].SetActive(true);
    }
}
