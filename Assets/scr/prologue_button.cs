using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static prologue_manager;
using UnityEngine.SceneManagement;
public class prologue_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button_colick(){
        if(page<2){
            page+=1;
            page_sh2[page-1].SetActive(false);
            page_sh2[page].SetActive(true);
        }
        else
            SceneManager.LoadScene("main");
        
    }
}
