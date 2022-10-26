using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    bool explode = false;
    bool describe = false;
    [SerializeField] private GameObject explosionPanel;
    [SerializeField] private GameObject descriptionPanel;
    public void Explode()
    {
        explode = !explode;
        explosionPanel.SetActive(explode);
    }

    public void Description()
    {
        describe = !describe;
        descriptionPanel.SetActive(describe);
        Debug.Log("Described");
    }

    public void Apparatus()
    {
        Debug.Log("Shown Apparatus");
    }
}
