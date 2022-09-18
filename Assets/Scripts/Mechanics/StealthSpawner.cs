using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthSpawner : MonoBehaviour
{
    int seconds;

    public GameObject conditionPrefab;

    public Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        float height = cam.orthographicSize;
        float width = cam.orthographicSize * cam.aspect + 1;

        if (Time.time > seconds)
        {
            seconds += 10;
            Instantiate(conditionPrefab, new Vector2(cam.transform.position.x + Random.Range(-width, width), cam.transform.position.y + Random.Range(-4, 4)), Quaternion.identity);
        }
    }
}
