using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour {

public void loadscene(string scena)
    {
        SceneManager.LoadScene(scena);
    }
}
