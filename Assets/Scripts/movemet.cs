using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movemet : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController characterController;
    //private CharacterControllerDriver driver;
    //private XRRig xRRig;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //driver =  GetComponent<CharacterControllerDriver>();
        //xRRig = GetComponent<XRRig>();
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateCharacterController();
    }
    /*
    protected virtual void UpdateCharacterController()
    {
        if (xRRig == null || characterController == null)
            return;

        var height = Mathf.Clamp(xRRig.cameraInRigSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = xRRig.cameraInRigSpacePos;
        center.y = height / 2f + characterController.skinWidth;

        characterController.height = height;
        characterController.center = center;
    }
    */
}
