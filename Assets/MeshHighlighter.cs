using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshHighlighter : MonoBehaviour
{
    public Material highlightMat;
    
    // Start is called before the first frame update
    void Start()
    {
        highlightMat.SetFloat("Boolean_3EA6FF12", 0f);
    }

    private void OnMouseEnter()
    {
        highlightMat.SetFloat("Boolean_3EA6FF12", 1f);
    }
    private void OnMouseExit()
    {
        highlightMat.SetFloat("Boolean_3EA6FF12", 0f);
    }
}
