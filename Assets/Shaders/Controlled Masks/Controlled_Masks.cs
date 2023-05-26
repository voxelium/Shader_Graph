using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static Unity.VisualScripting.Metadata;
using static UnityEngine.GraphicsBuffer;

public class Controlled_Masks : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private Material maskedMat;
    private TargetMask[] targetsMasks;
    [SerializeField] private string[] masksArray;
    [SerializeField] LayerMask layerPlaine;
    private int currentMaskNum;

    private int mask00;
    private int mask01;
    private int mask02;

    private void Awake()
    {
        maskedMat = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        targetsMasks = GetComponentsInChildren<TargetMask>();
        currentMaskNum = 0;
    }

    private void Update()
    {
        //Тест на привязку таргетов к маскам
        //maskedMat.SetVector(masksArray[0], targetsMasks[0].transform.localPosition);
        //maskedMat.SetVector(masksArray[1], targetsMasks[1].transform.localPosition);
        //maskedMat.SetVector(masksArray[2], targetsMasks[2].transform.localPosition);

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    Vector3 screenPosition = camera.ScreenToWorldPoint(Input.GetTouch(0).position);

        //    Debug.Log(screenPosition);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerPlaine))
            {
                maskedMat.SetVector(masksArray[0], raycastHit.point);
            }

            //Debug.Log(clickPosition);
        }


    }


    private void SetNewMaskPosition()
    {
        maskedMat.SetVector(masksArray[currentMaskNum], targetsMasks[2].transform.localPosition);
        currentMaskNum++;
    }
}
