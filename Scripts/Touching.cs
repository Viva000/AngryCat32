using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touching : MonoBehaviour
{
  private int hp = 10;
  private Transform spawnpoint;
  private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = GameObject.Find("SpawnPoint").transform;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Damage(int value)
    {
      rb2d.velocity = Vector2.zero;
      rb2d.angularVelocity = 0;
      rb2d.isKinematic = true;
      transform.position = spawnpoint.position;
      hp -= value;
      if(hp <= 0);
      {
        SceneManager.LoadScene(0);
      }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.CompareTag("Obstacle"))
      {
        Damage(other.GetComponent<ObstacleSetings>().damageValue);
      }
    }
}
