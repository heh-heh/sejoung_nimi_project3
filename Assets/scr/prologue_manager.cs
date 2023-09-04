using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class prologue_manager : MonoBehaviour
{
    // Start is called before the first frame update
    static public int page = 0;
    public List<GameObject> page_sh = new List<GameObject>();
    static public List<GameObject> page_sh2 = new List<GameObject>();

    public TextMeshProUGUI page_button;
    void Start()
    {
        page_sh2=page_sh;

        page_button.text = "next";
        page_sh[0].SetActive(true);
        page_sh[1].SetActive(false);
        page_sh[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(page>=2)page_button.text = "game start";
    }
}
