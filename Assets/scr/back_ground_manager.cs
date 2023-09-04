using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static gamemanager;

public class back_ground_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> back_ground = new List<GameObject>();
    static public  List<GameObject> back_ground_static = new List<GameObject>();
    void Start()
    {
        back_ground_static=back_ground;
        for(int i=0; i<back_ground.Count; i++){
            back_ground[i].SetActive(false);
        }

        back_ground[3].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
