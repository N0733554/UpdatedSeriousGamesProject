﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public Camera mainCamera;
    public Module[] moduleList;

    public Camera getCamera()
    {
        return mainCamera;
    }

    public void EnableModules()
    {
        foreach (Module m in moduleList)
        {
            m.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void DisableModules()
    {
        foreach (Module m in moduleList)
        {
            m.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public bool isComplete()
    {
        foreach(Module m in moduleList)
        {
            if (!m.isComplete)
                return false;
        }
        FindObjectOfType<GameManager>().EndGame(true);
        return true;
    }
}
