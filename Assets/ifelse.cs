using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse : MonoBehaviour
{
    int sayi1 = 10;
    int sayi2 = 20;
    string ad1 ="ayşe";
    string ad2 ="gül";
    bool kapiAcikMi = false;

    void Start()
    {
        if (sayi1 < sayi2)
            Debug.Log("1. sayı 2. sayıdan küçüktür.");

        else if (sayi1 == sayi2)
            Debug.Log("1. sayı ile 2. sayı aynıdır.");   

        else
            Debug.Log("1. sayı 2. sayıdan büyüktür.");

        if(ad1 != ad2 )
           Debug.Log("Adlar aynı değildir.");   

        else
           Debug.Log("Adlar aynıdır.");   

        if (!kapiAcikMi)
        Debug.Log("Kapı açık."); 
        else
        Debug.Log("Kapı açık değil.");
        

        
    }
}
