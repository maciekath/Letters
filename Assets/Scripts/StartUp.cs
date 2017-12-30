using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class StartUp : MonoBehaviour {

 public  static Dictionary<string, Wyraz> slownik = new Dictionary<string, Wyraz>();
    public static int los;
    public List<Sprite> sprites;

    void Start() {

        for (int i = 0; i < sprites.Count; i++)
        {
            Debug.Log(sprites[i].name);

        }
        InputField input = GameObject.Find("templemate").GetComponentInChildren<InputField>();
        var ObjectToDeactivate = GameObject.Find("templemate").GetComponentInChildren<InputField>();


        var g = GameObject.Find("gr").GetComponentInChildren<Image>();
        g.gameObject.SetActive(false);
        var g1 = GameObject.Find("j").GetComponentInChildren<Image>();
        g1.gameObject.SetActive(false);
        System.Random rnd = new System.Random();
        int losowanie = rnd.Next(0, 2);
        los = losowanie;
        string w = "JABLKO";
        string gruszka = "GRUSZKA";

        Wyraz w0 = new Wyraz(w);
        Wyraz w1 = new Wyraz(gruszka);

        w0.dodajdolisty();

        w1.dodajdolisty();

        if (!slownik.ContainsKey(w))
            slownik.Add(w, w0);
        if (!slownik.ContainsKey(gruszka))
            slownik.Add(gruszka, w1);
        if (losowanie == 0)
        {
            g1.gameObject.SetActive(true);
        }
        if (losowanie == 1)
        {

            g.gameObject.SetActive(true);
        }
        Text textscript = GameObject.Find("Title").GetComponentInChildren<Text>(); // This will get the script responsable for editing text
        textscript.text = "Podaj pierwszą litere wyrazu ";

        List<InputField> litery = new List<InputField>();
        int przesuniecie = 30;
        switch (losowanie)
        {
            case 0:
        for (int i = 1; i < w.Length + 1; i++)
        {


            litery.Add(Instantiate<InputField>(input, input.transform.parent));
            InputField field = GameObject.Find("templemate(Clone)").GetComponentInChildren<InputField>();
            field.transform.localPosition = new Vector3(-150 + przesuniecie, -100, 0);
            field.name = "F" + i;

            przesuniecie += 30;

        }
                break;
            case 1:
                for (int i = 1; i < gruszka.Length + 1; i++)
                {


                    litery.Add(Instantiate<InputField>(input, input.transform.parent));
                    InputField field = GameObject.Find("templemate(Clone)").GetComponentInChildren<InputField>();
                    field.transform.localPosition = new Vector3(-150 + przesuniecie, -100, 0);
                    field.name = "F" + i;

                    przesuniecie += 30;

                }
                break;
        }
        ObjectToDeactivate.gameObject.SetActive(false);

    }



}
public class Wyraz
{
    public string name;
   public ArrayList l =new ArrayList();
    public Wyraz(string name)
    {
        this.name = name;
     
     
    }
    public Wyraz() { }

 public ArrayList litery
        {
        get { return l; }
    }
    public void dodajdolisty()
    {
       foreach (char z in name)
        {
       
            l.Add(z);
        
        }
       
      

        }
}
