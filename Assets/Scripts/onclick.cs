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
        int l = StartUp.los;
        ArrayList lis = new ArrayList(StartUp.slownik.Values);
        Wyraz w =(Wyraz) lis[l];
        ArrayList w1 = new ArrayList(w.litery);
        if (button.name=="Restart")
        {
            SceneManager.LoadScene("Scena");
            licznik = 0;
        }
        if (button.name=="Exit")
        {
            SceneManager.LoadScene("Start");
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
        if (licznik <= w1.Count)
        {
            InputField textscript = GameObject.Find("F" + licznik).GetComponentInChildren<InputField>(); // This will get the script responsable for editing text
            Debug.Log(textscript.name);

            textscript.text = button.name;
           textscript.enabled = false;
            textscript.enabled = true;
           

           
        }
   
        if (licznik == w1.Count)
        {
            for (int i = 1; i <= w1.Count; i++)
            {
                InputField input = GameObject.Find("F" + i).GetComponentInChildren<InputField>();

                Debug.Log(input.text + ":" + w1[i - 1].ToString());
                if (input.text == w1[i - 1].ToString())
                {
                    Debug.Log(input.text + ":" + w1[i - 1].ToString());
                    ColorBlock color = input.colors;
                    color.highlightedColor = Color.green;
                    color.normalColor = Color.green;
                    input.colors = color;

                }
            }
        }

    }
}
