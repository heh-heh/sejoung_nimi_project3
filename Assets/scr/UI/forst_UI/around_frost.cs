using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class around_frost : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sh_forst2_UI;
    public GameObject hid_forst_UI;
    public List<GameObject> shop_UI = new List<GameObject>();
    int random = 0;
    void Start()
    {
        sh_forst2_UI.SetActive(false);
        hid_forst_UI.SetActive(true);
        shop_UI[0].SetActive(false);
        shop_UI[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ch_UI(){
        random = Random.Range(0,2);
        shop_UI[random].SetActive(true);
        Debug.Log(random);
        hid_forst_UI.SetActive(false);
        sh_forst2_UI.SetActive(true);
    }
}
