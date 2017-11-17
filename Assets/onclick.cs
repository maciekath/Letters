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
    
        Text tiltlet = GameObject.Find("Title").GetComponentInChildren<Text>();
        tiltlet.color = Color.black;
          
        if (licznik == 5)
        {
            tiltlet.text = "Podaj ostatnią literę";
        }
       else if(licznik>=6)
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
        if (licznik <= 6)
        {
            InputField textscript = GameObject.Find("F" + licznik).GetComponentInChildren<InputField>(); // This will get the script responsable for editing text


            textscript.text = button.name;
            textscript.enabled = false;
            textscript.enabled = true;
           

           
        }
        if (licznik == Wyraz.litery.Count)
        {
            for (int i = 1; i <= Wyraz.litery.Count; i++)
            {
                InputField input = GameObject.Find("F"+i).GetComponentInChildren<InputField>();
               
                if (input.text == Wyraz.litery[i-1].ToString())
                {
                    ColorBlock color = input.colors;
                    color.highlightedColor = Color.green;
                    color.normalColor = Color.green;
                    input.colors = color;

                }
            }
        }

    }
}
