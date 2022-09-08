using UnityEngine;

public class MouseAiming : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    Vector2 currentVel;

    public Texture2D cursorTexture;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto); 
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePos;
    }

}