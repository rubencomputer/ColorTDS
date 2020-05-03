﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    public GameObject barraDeVida;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        var Units = GameObject.FindObjectsOfType<Unit>();

        foreach(var unit in Units)
        {
            if(unit.healthBar == false)
            {
                var healthBar = Instantiate(barraDeVida, new Vector2(unit.transform.position.x, unit.transform.position.y - 0.7f), Quaternion.identity);
                healthBar.GetComponent<healthBarBehavior>().currentOwner = unit.transform;
                unit.healthBar = true;
            }
        }
    }
}
