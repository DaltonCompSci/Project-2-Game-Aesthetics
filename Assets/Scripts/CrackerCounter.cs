using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CrackerCounter : MonoBehaviour
{

    public static CrackerCounter instance;

    public TMP_Text crackerText;
    public int currentCrackers = 0;


    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        crackerText.text = "Crackers Collected: " + currentCrackers.ToString();
    }

    // Update is called once per frame
    public void IncreaseCrackers(int v)
    {
        currentCrackers += v;
        crackerText.text = "Crackers Collected: " + currentCrackers.ToString();



    }




}
