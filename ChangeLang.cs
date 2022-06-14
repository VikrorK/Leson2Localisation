using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLang : MonoBehaviour
{
    public Dropdown dr;//выпадающий список
 
    void Start()
    {
        Proverka();
    }
    public void InputMenu(int value)
    {
        if(value == 0){
            Loacalisation.Inst.langs="ru";
            dr.value=0;
        }
        if(value == 1){
           Loacalisation.Inst.langs="en";
           dr.value=1;
        }
        
    }
    void Proverka(){
        if(Loacalisation.Inst.langs=="ru"){
            
            dr.value=0;
        }
        if(Loacalisation.Inst.langs=="en"){
           
           dr.value=1;
        }
        
    }
}
