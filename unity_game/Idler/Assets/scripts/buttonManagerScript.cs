using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManagerScript : MonoBehaviour
{
    public int n;
    public Text buttonNum;
    public void OnButtonPress()
    {
        n++;
        buttonNum.text = "Button has been pressed " + n + " times.";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
