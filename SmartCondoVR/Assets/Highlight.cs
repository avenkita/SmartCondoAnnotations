/*using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {
    private GameObject currentObject;
    private Color oldColor;
    private float highlightFactor = 0.2f;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Vector3.one)
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            (currentObject == null)
            currentObject = hit.transform.gameObject;
            HighlightCurrentObject();
        }
        else if (hit.transform != currentObject.transform)
        {
            RestoreCurrentObject();
            currentObject = hit.transform.gameObject;
            HighlightCurrentObject();
        }
        else
            RestoreCurrentObject();
    }

    private void HighlightCurrentObject()
    {
        Renderer r = currentObject.GetComponent(typeof(Renderer)) as Renderer;
        oldColor = r.material
    }
}*/
