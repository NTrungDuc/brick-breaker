using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class block : MonoBehaviour
{
    public static int numberBlock;
    void Start()
    {
        numberBlock = FindObjectsOfType<blockManager>().Length;
    }
}
