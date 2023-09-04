using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ese_UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(UI_manager.ese_UI_bool == false) UI_manager.ese_UI_bool = true;
            else UI_manager.ese_UI_bool = false;
        }
    }

    
}
