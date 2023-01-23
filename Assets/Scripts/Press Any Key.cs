using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyKey : MonoBehaviour
{
    public KeyCode keyToPress;
    public bool freezenOnStart = true;
    public GameObject objectToHide;

    // Start is called before the first frame update
    void Start()
    {
        if(freezenOnStart)
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) 
        {
            Time.timeScale = 1;
            objectToHide.SetActive(false);
        }
    }
}
