using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profile_face : MonoBehaviour
{
    public List<GameObject> face = new List<GameObject>();

    public Slider player_hp;
    // Start is called before the first frame update
    void Start()
    {
        face[0].SetActive(true);
        face[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player_hp.value <= 0.25){ face[1].SetActive(true); face[0].SetActive(false);}
        else{ face[0].SetActive(true); face[1].SetActive(false);}
    }
}
