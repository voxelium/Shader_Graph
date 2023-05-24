using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Metadata;
using static UnityEngine.GraphicsBuffer;

public class Controlled_Masks : MonoBehaviour
{
    [SerializeField] private Material maskedMat;
    private TargetMask[] allTargetMasks;

    private int targetsAmount;
    private int currentTarget;

    private void Start()
    {
        allTargetMasks = GetComponentsInChildren<TargetMask>();
        targetsAmount = allTargetMasks.Length;

        Debug.Log(allTargetMasks[0].name);
        


    }

}
