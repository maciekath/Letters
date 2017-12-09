using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour {

    public ttt[] obiekty = new ttt[10];

    public void PokazMenu()
    {

    }

	void Start () {

        var obrazek = GameObject.Find("jabłko");
        var word = obrazek.GetComponent<ttt>().word;
        Debug.Log(word);

        string w = "JABLKO";
        Wyraz wyraz = new Wyraz(w);
        if (Wyraz.litery.Count==0)
        wyraz.dodajdolisty();

        Text textscript = GameObject.Find("Title").GetComponentInChildren<Text>(); // This will get the script responsable for editing text
        textscript.text = "Podaj pierwszą litere wyrazu ";
        InputField input = GameObject.Find("F1").GetComponentInChildren<InputField>();
        List<InputField> litery = new List<InputField>();
        int przesuniecie = 30;
        for (int i = 2; i < w.Length+1; i++)
        {
        

            litery.Add(Instantiate<InputField>(input, input.transform.parent));
            InputField field = GameObject.Find("F1(Clone)").GetComponentInChildren<InputField>();
            field.transform.localPosition = new Vector3(-150+przesuniecie, -100, 0);
            field.name = "F"+i;
        
            przesuniecie += 30;
       
        }

    }


    // Update is called once per frame
    void Update () {
       
    }
}
public class Wyraz
{
    public string name;
 static   public ArrayList l =new ArrayList();
    public Wyraz(string name)
    {
        this.name = name;
     
    }
    public Wyraz() { }
 static   public ArrayList litery
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
