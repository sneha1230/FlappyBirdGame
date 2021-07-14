using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float minY, maxY;
    float randY;
    float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
       ColumnGenerator();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.gameOver==false)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                ColumnGenerator();
                timer = 0;
            }
        }
    }
    void ColumnGenerator()
    {
        randY = Random.Range(minY, maxY);
        GameObject tempColumn=Instantiate(columnPrefab);
        tempColumn.transform.position = new Vector2(transform.position.x, randY);
    }
}
