using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_UI_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static public void show()
    {
        if(UI_manager.bag_UI_bool == false) UI_manager.bag_UI_bool = true;
        else UI_manager.bag_UI_bool = false;
    }
}
