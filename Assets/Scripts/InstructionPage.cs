using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPage : MonoBehaviour
{
    public GameObject AnotherInst;
    public GameObject Instructions;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Main_menu;
    //
    
    public void NextPage()
    {
        Instructions.SetActive(false);
        Page2.SetActive(false);
        Main_menu.SetActive(false);
        Page1.SetActive(true);
        AnotherInst.SetActive(true);
    }
    public void PreviousPage()
    {
        Instructions.SetActive(true);
        Page2.SetActive(true);
        Main_menu.SetActive(true);
        Page1.SetActive(false);
        AnotherInst.SetActive(false);
    }
}
