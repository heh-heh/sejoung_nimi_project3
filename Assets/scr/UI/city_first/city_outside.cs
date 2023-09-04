using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UI_manager;
using static back_ground_manager;

public class city_outside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move_city_outside(){
        back_ground_static[0].SetActive(false);
        back_ground_static[2].SetActive(true);
        UI_list_static[2].SetActive(false);
        UI_list_static[3].SetActive(true);
    }
}
