using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ese_UI_couitnue_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void counitnue_button(){
        if(UI_manager.ese_UI_bool == true) UI_manager.ese_UI_bool=false;
    }
}
