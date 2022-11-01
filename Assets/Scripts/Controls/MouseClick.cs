using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Animator anim;
    int toggleLens = -1;
    [SerializeField] MicroscopeImaging mi;
    [SerializeField] TutorialManager tutorialManager;
    [SerializeField] Transform stage;
    [SerializeField] GameObject illuminatorLight;
    private void Start()
    {
        if (gameObject.name == "glass plate")
        {
            anim = GetComponent<Animator>();
        }
    }
    private void OnMouseDown()
    {
        //Step 1
        switch (tutorialManager.popUpIndex)
        {
            case 2:

                anim.SetBool("clicked", true);
                break;
            case 3:
                if (this.gameObject.name == "4X Lens" || this.gameObject.name == "10X Lens" || this.gameObject.name == "40X Lens" || this.gameObject.name == "100X Lens")
                {
                    mi.DisplayImage(0);
                }
                break;
            case 4:

                if (this.gameObject.name == "Rotating Nosepiece")
                {

                    mi.DisplayImage(++toggleLens);
                }
                break;
            case 5:
                if (this.gameObject.name == "Coarse Adjustment" || this.gameObject.name == "Fine Adjustment")
                {
                    stage.position += new Vector3(stage.position.x, 0.01f, stage.position.z);
                }
                break;
            case 6:
                if (this.gameObject.name == "Illuminator")
                {
                    illuminatorLight.SetActive(true);
                    mi.DisplayLitImage();
                }
                break;
            default: break;
        }
    }

}
