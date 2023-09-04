using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_manager : MonoBehaviour
{
    // Start is called before the first frame update
    static public bool ese_UI_bool  = false;
    public GameObject ese_UI;
    static public bool bag_UI_bool = false;
    public GameObject bag_UI;

    public List<GameObject> UI_list = new List<GameObject>();
    static public List<GameObject> UI_list_static = new List<GameObject>();
    void Start()
    {
        ese_UI.SetActive(false);
        bag_UI.SetActive(false);
        UI_list_static=UI_list;

        for(int i=0; i<UI_list.Count; i++){
            UI_list[i].SetActive(false);
        }
        UI_list[4].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        ese_UI.SetActive(ese_UI_bool);
        bag_UI.SetActive(bag_UI_bool);
    }
}
