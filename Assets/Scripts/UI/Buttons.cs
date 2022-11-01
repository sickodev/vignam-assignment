using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buttons : MonoBehaviour
{
    bool explode = false;
    bool describe = false;
    bool apparatus = false;

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject apparatusPanel;
    [SerializeField] private GameObject explosionPanel;
    [SerializeField] private GameObject descriptionPanel;

    MouseHover mouseHover;
    public void Explode()
    {
        explode = !explode;
        animator.SetBool("explode", explode);
        explosionPanel.SetActive(explode);
    }

    public void Description()
    {
        describe = !describe;
        descriptionPanel.SetActive(describe);
    }

    public void Apparatus()
    {
        apparatus = !apparatus;
        apparatusPanel.SetActive(apparatus);
    }
}
