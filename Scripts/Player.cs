using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  private float ForceValue = 1200f;
  private float MinSpeedToDrag = 0.1f;
  private Rigidbody2D rb2d;
  private Camera mainCamera;
  private Vector2 StartPosition;
  private bool CanDrag = true;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseDown()
    {
      float playerSpeed = rb2d.velocity.magnitude;
      if(playerSpeed < MinSpeedToDrag)
      {
        CanDrag = true;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector2.zero;
        StartPosition = rb2d.position;
      }

    }
    private void OnMouseUp()
    {
      if(CanDrag == true)
      {
        Vector2 currentPosition = rb2d.position;
        Vector2 direction = StartPosition - currentPosition;
        rb2d.isKinematic = false;
        rb2d.AddForce(direction * ForceValue);
      }
    }

    private void OnMouseDrag()
    {
      if(CanDrag)
      {
        Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
      }
    }
}
