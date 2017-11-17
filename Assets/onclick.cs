using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onclick : MonoBehaviour {

    public ColorBlock colorBlockHuman;
 public int licznik ;
    public void Wypiszlitere(Button button)
    {
        if (button.name=="Restart")
        {
            SceneManager.LoadScene("Scena");
        }

        licznik++;
        Debug.Log(licznik);
        Text tiltlet = GameObject.Find("Title").GetComponentInChildren<Text>();
        tiltlet.color = Color.black;
          
        if (licznik == 2)
        {
            tiltlet.text = "Podaj ostatnią literę";
        }
       else if(licznik>2)
        {
            tiltlet.text = "Wygrałes";
        }
        else
        {
            tiltlet.text = "Podaj nastepną literę";
        }
        ColorBlock colorVar = button.colors;
        colorVar.highlightedColor = Color.black;
        colorVar.normalColor= Color.black;
        button.colors = colorVar;
        if (licznik <= 2)
        {
            InputField textscript = GameObject.Find("F" + licznik).GetComponentInChildren<InputField>(); // This will get the script responsable for editing text


            textscript.text = button.name;
            textscript.enabled = false;
            textscript.enabled = true;
           

           
        }
        
    }
}
