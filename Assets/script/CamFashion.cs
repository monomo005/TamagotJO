using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFashion : MonoBehaviour
{
       public Transform zoomInPlayer;
    public Transform zoomOutPlayer;
    public float speed;

    public bool isZoomed = false;

    private void Update()
    {
        if (isZoomed)
        {
            zoomFashion();
        }
        if(!isZoomed)
        {
            zoomOut();
        }
    }

    public void zoomFashion()
    {
        isZoomed = true;
        transform.position = Vector3.Lerp(transform.position, zoomInPlayer.position, Time.deltaTime * speed);
    }

    public void zoomOut()
    {
        isZoomed = false;
        transform.position = Vector3.Lerp(transform.position, zoomOutPlayer.position, Time.deltaTime * speed);
    }
}
