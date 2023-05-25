using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Metadata;
using static UnityEngine.GraphicsBuffer;

public class Controlled_Masks : MonoBehaviour
{
    //[SerializeField] private Material maskedMat;
    [SerializeField] Transform testTransform;
    private Material maskedMat;
    //private TargetMask[] targetsMasks;
    private Transform[] targetsMasks;


    private int targetsAmount;
    private int currentTarget;

    private void Awake()
    {
        maskedMat = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        targetsMasks = GetComponentsInChildren<Transform>();
        targetsAmount = targetsMasks.Length;

        
    }

    private void Update()
    {
        maskedMat.SetVector("_Mask_01_Position", testTransform.position);
    }

}
