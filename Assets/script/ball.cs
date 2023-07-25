using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public Text score;
    int h = 0;
    public GameObject gameOver;
    public GameObject winner;
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 800);
        score = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(block.numberBlock == 0)
        {
            Time.timeScale = 0;
            audioSource.enabled = false;
            winner.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            audioSource.enabled = false;
            Time.timeScale = 0;
            gameOver.SetActive(true);
           
        }
        if(collision.gameObject.tag == "block")
        {
            Destroy(collision.gameObject);
            h += 1;
            score.text = h.ToString();
            block.numberBlock -= 1;
            
        }
    }
    
}
