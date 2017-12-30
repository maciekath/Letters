using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class KeyBoardsBtn : MonoBehaviour {
    

	
	// Update is called once per frame
	void Update () {
        KeyCode key = KeyCode.A;
        char kname = gameObject.name.ToCharArray()[0];
        int offset = kname - 'A';
        key = (KeyCode)(key + offset);
        if (Input.GetKeyDown(key))
        {
       GetComponent<Button>().onClick.Invoke();

        }
	}
}
