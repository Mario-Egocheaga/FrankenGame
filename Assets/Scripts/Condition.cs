using UnityEngine;

public class Condition : MonoBehaviour
{
    public static bool inArea = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Condition")
        {
            inArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }
}
