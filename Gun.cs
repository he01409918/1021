using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Gun : VRTK_InteractableObject
{
    public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    {
        base.StartUsing(currentUsingObject);
        Debug.Log("按下板機");
    }
}
