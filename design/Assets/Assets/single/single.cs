﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class single : MonoBehaviour
{
    public static single instance;

    // Start is called before the first frame update
    private void Awake()
    {if (instance == null)
            instance = this;
        else
        {
            return;
        }
    }
    void Start()
    {   
             

        // Update is called once per frame
      
    }

    void Update()
    {

    }
}
