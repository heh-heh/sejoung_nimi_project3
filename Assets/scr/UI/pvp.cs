using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pvp : MonoBehaviour
{
    // Start is called before the first frame update
    static public float mop_hp= 80 ;
    public Slider mop_HP_bar;
    public TextMeshProUGUI mop_hp_txt;
    void Start()
    {
        mop_hp_txt.text = ""+mop_hp + "/ 80";
    }

    // Update is called once per frame
    void Update()
    {
        mop_hp_txt.text = ""+mop_hp + "/ 80";
        mop_HP_bar.value = mop_hp / 80;
    }
}
