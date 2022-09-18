using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionSpawner : MonoBehaviour
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
        float width = cam.orthographicSize * cam.aspect;

        if (Time.time > seconds)
        {
            seconds += 7;
            Instantiate(conditionPrefab, new Vector2(cam.transform.position.x + Random.Range(-width, width), cam.transform.position.y + Random.Range(-4, 4)), Quaternion.identity);
        }
    }
}
