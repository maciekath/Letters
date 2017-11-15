using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour {
  
	void Start () {

        Text textscript = GameObject.Find("Title").GetComponentInChildren<Text>(); // This will get the script responsable for editing text
        textscript.text = "Podaj pierwszą litere wyrazu jabłko";

    }


    // Update is called once per frame
    void Update () {
      
    }
}
