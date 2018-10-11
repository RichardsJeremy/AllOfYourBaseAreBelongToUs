using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jeremy Richards S3721762
public class EnemyMovement : MonoBehaviour {
    public float minSpeed;
    public float maxSpeed;
    private Vector3 originPosition;
    private Vector3 destinationPosition;
    private float trueSpeed;
    public GameObject enemyObject;
    void Start()
    {
        trueSpeed = Random.Range(minSpeed, maxSpeed);
        originPosition = gameObject.transform.position;
        destinationPosition = FindEdgeFor(gameObject);
    }
    void Update()
    {
        Vector3 currentPos = enemyObject.transform.position;
        float newX = currentPos.x;
        float newY = currentPos.y;
        float newZ = currentPos.z;
        if (currentPos.y < destinationPosition.y - trueSpeed)
        {
            newY += trueSpeed;
        }
        else if (currentPos.y > destinationPosition.y + trueSpeed)
        {
            newY -= trueSpeed;
        }
        else
        {
            newY = destinationPosition.y;
        }
        if (currentPos.x > destinationPosition.x + trueSpeed)
        {
            newX -= trueSpeed;
        }
        else if (currentPos.x < destinationPosition.x - trueSpeed)
        {
            newX += trueSpeed;
        }
        else
        {
            newX = destinationPosition.x;
        }
        Vector3 movePos = new Vector3(newX, newY, newZ);
        enemyObject.transform.position = movePos;

        if (enemyObject.transform.position == destinationPosition)
        {
            destinationPosition = originPosition;
            originPosition = gameObject.transform.position;
        }
    }

    private Vector3 FindEdgeFor(GameObject enemyObject)
    {
        Vector3 currentPos = enemyObject.transform.position;
        float objWidth = enemyObject.GetComponent<SpriteRenderer>().bounds.size.x;
        float objHeight = enemyObject.GetComponent<SpriteRenderer>().bounds.size.y;
        float distUp = Mathf.Abs(0.5f * Screen.height / 100.0f - 0.5f * objHeight - currentPos.y);
        float distDown = Mathf.Abs(-0.5f * Screen.height / 100.0f + 0.5f * objHeight - currentPos.y);
        float distLeft = Mathf.Abs(-0.5f * Screen.width / 100.0f + 0.5f * objWidth - currentPos.x);
        float distRight = Mathf.Abs(0.5f * Screen.width / 100.0f - 0.5f * objWidth - currentPos.x);
        float maxDist = Mathf.Max(distUp, distDown, distLeft, distRight);
        float edgeX = currentPos.x;
        float edgeY = currentPos.y;
        float edgeZ = currentPos.z;
        if (maxDist == distUp)
        {
            edgeY += distUp;
        }
        else if (maxDist == distDown)
        {
            edgeY -= distDown;
        }
        else if (maxDist == distLeft)
        {
            edgeX -= distLeft;
        }
        else if (maxDist == distRight)
        {
            edgeX += distRight;
        }
        Vector3 edgePos = new Vector3(edgeX, edgeY, edgeZ);
        return edgePos;
    }
}
