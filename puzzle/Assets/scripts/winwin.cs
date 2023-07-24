using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winwin : MonoBehaviour
{
     int elements;
    public static int rightElements;

    public GameObject puzzle; 
    public GameObject panel;
    public GameObject winP;
    

    void Start()
    {
        elements = puzzle.transform.childCount;
    }

    void Update()
    {
        if( elements==rightElements) 
        { 
          panel.SetActive(false);
            winP.SetActive(true);
        }
    }

    public static void AddE()
    {
      rightElements++;
    }

    public static void ResetProgress()
    {
        rightElements = 0;
    }
}
