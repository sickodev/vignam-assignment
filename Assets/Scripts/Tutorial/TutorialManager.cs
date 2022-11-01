using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    [Header("Tutorial")]
    public GameObject[] popups;
    [SerializeField] Button nextButton;
    [SerializeField] GameObject endExperiment;

    [Header("Camera ")]
    [SerializeField] Transform mainCamera;
    public Vector3 cameraPoint1;
    public Vector3 cameraPoint2;

    float moveDelta = 0.9f;
    public int popUpIndex = 0;


    void Start()
    {
        nextButton.onClick.AddListener(Next);
    }

    void Update()
    {
        switch (popUpIndex)
        {
            case 0:
                popups[popUpIndex].SetActive(true);
                break;
            case 1:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                break;
            case 2:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                break;
            case 3:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                break;
            case 4:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                break;
            case 5:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                mainCamera.position = Vector3.MoveTowards(mainCamera.position, cameraPoint1, moveDelta);
                break;
            case 6:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                mainCamera.position = Vector3.MoveTowards(mainCamera.position, cameraPoint2, moveDelta);
                break;
            case 7:
                popups[popUpIndex].SetActive(true);
                popups[popUpIndex - 1].SetActive(false);
                break;
            default:

                try
                {
                    popups[popUpIndex - 1].SetActive(false);
                    endExperiment.SetActive(true);
                    break;
                }
                catch (System.Exception)
                {
                    if (popUpIndex > popups.Length)
                    {
                        SceneManager.LoadScene("Finish Scene");
                    }
                    break;
                }

        }


    }

    void Next()
    {
        popUpIndex++;
    }


}
