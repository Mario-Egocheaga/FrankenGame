using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    float scale = 2.5f;

    private void FixedUpdate()
    {
        scale -= 0.01f;
        transform.localScale = new Vector2(scale, scale);

        if (scale <= .01f)
        {
            Destroy(gameObject);
        }
    }
}
