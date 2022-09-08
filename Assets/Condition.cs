using UnityEngine;

public class Condition : MonoBehaviour
{
    public bool inArea;
    public GameObject prefab;

    void Update()
    {
        if (inArea && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Orb")
        {
            inArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }
}
