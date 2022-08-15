using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

public class InputView : BaseView
{
    
    void Update()
    {
            
    }

    public bool ReadButtonDown(KeyCode _key)
    {
        if (Input.GetKeyDown(_key))
        {
            return true;
        }
        else return false;
    }
    
}
