using System.Collections;
using UnityEngine;

public class MouseAiming : MonoBehaviour
{
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 worldPos;

        mousePos.z = Camera.main.nearClipPlane;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
    }

}
}
