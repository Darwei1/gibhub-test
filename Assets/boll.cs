using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boll : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    Vector3 dir;

    int player1goal = 0;
    int player2goal = 0;
    [SerializeField] int bollfart = 7;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
        transform.position += dir * bollfart * Time.deltaTime;
        if (transform.position.x > 25)
        { 
            player1goal += 1;
            print("Spelare 1 mål");
            ResetBall();
        }
        else if (transform.position.x < -25)
        {
            player2goal += 1;
            print("Spelare 2 mål");
            ResetBall();
        }
        
    }
    private void ResetBall()
    {
        bollfart = 5;
        scoreText.text = player1goal + " - " + player2goal;
        transform.position = new Vector3(0, 0, 0);
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            dir.x *= -1;
            if (bollfart < 30);
            {
                bollfart += 1;
            }
            
        }
        else
        {
            dir.y *= -1;
        }

      
    }
    }


