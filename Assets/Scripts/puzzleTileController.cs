using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleTileController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentTile, tileToSpawn;
    private Vector3 midTilePosition, leftTilePosition, rightTilePosition;

    public float timeOffset = 6.0f;
    private float startTime;

    private int currentTileNo = 1, prevTileNo = 1; //1 means middle, 2 means right, 0 means left

    void Start()
    {
        midTilePosition = currentTile.transform.position;
        leftTilePosition = new Vector3((float)(-4.2), midTilePosition.y, midTilePosition.z);
        rightTilePosition = new Vector3((float)(4.2), midTilePosition.y, midTilePosition.z);

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > timeOffset)
        {
            prevTileNo = currentTileNo;
            currentTileNo = (currentTileNo + 1) % 3;
            startTime = Time.time;

            if (currentTileNo == 2)
            {
                currentTile.transform.position = rightTilePosition;
            }
            else if (currentTileNo == 0)
            {
                currentTile.transform.position = leftTilePosition;
            }
            else
            {
                currentTile.transform.position = midTilePosition;
            }
        }
    }
}
