using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IzminenieLangText : MonoBehaviour
{
    public string onru;//текст на русском
    public string onen;//текст на английском
    public Text textS;//объект текст
   
    //проверяем текущий язык и выставляем текст согласно выбраному языку со старта
    void Start()
    {
        IzmenText();
    }

    //проверяем текущий язык и выставляем текст согласно выбраному языку во время
    void Update()
    {
       IzmenText();
    }
    
public void IzmenText(){
        if(Loacalisation.Inst.langs=="ru"){
            textS.text=onru;
        }
        if(Loacalisation.Inst.langs=="en"){
            textS.text=onen;
        }
    }
}
