using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPage : MonoBehaviour
{
    // Color, Hat, Pet, Skin
    public GameObject[] pageArr = new GameObject[4];
    

    public void colorPage() { showPage(0); }
    public void hatPage() { showPage(1); }
    public void petPage() { showPage(2); }
    public void skinPage() { showPage(3); }


    public void showPage(int checkNum)
    {
        for (int i = 0; i< pageArr.Length; i++) {
            if (i == checkNum)
            {
                pageArr[i].SetActive(true);
            }
            else {
                pageArr[i].SetActive(false);
            }
        }
        
    }
    
    
}
