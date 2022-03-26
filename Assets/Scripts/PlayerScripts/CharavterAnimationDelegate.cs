using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharavterAnimationDelegate : MonoBehaviour
{
    public GameObject rightLegAttackPoint, leftLegAttackPoint, rightArmAttackPoint, leftArmAttackPoint;
   

    void LeftArmAttackOn()
    {
        leftArmAttackPoint.SetActive(true);
    }
    void LeftArmAttackOff()
    {
        if(leftArmAttackPoint.activeInHierarchy)
        leftArmAttackPoint.SetActive(false);
    }

    void RightArmAttackOn()
    {
        rightArmAttackPoint.SetActive(true);

    }

    void RightArmAttackOff()
    {
        if (rightArmAttackPoint.activeInHierarchy)
            rightArmAttackPoint.SetActive(false);
    }

    void LeftLegAttackOn()
    {
        leftLegAttackPoint.SetActive(true);
    }

    void LeftLegAttackOff()
    {
        if (leftLegAttackPoint.activeInHierarchy)
            leftLegAttackPoint.SetActive(false);
    }

    void RightLegAttackOn()
    {
        rightLegAttackPoint.SetActive(true);
    }

    void RightLegAttackOff()
    {
        if (rightLegAttackPoint.activeInHierarchy)
            rightLegAttackPoint.SetActive(false);
    }
}
