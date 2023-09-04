using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UI_manager;
using static back_ground_manager;

public class city_insid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move_city_inside(){
        UI_list_static[2].SetActive(false);
        UI_list_static[1].SetActive(true);
        back_ground_static[0].SetActive(false);
        back_ground_static[1].SetActive(true);
    }

    public void move_inside_to_outside(){
        UI_list_static[3].SetActive(false);
        UI_list_static[1].SetActive(true);
        back_ground_static[2].SetActive(false);
        back_ground_static[1].SetActive(true);
    }

}
