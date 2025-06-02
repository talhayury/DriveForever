using System.Diagnostics;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CarButNpc : MonoBehaviour
{
    //[SerializeField] private GameObject _carPrefabs;
    //[SerializeField] private float _spawnTime;
    [SerializeField] private Sprite[] sprites;
    SpriteRenderer spr;

    private float _defSpeed;
    private int _serit;

    private int _carSprite;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();

        _defSpeed = Random.Range(2.5f, 3.5f);
        _serit = Random.Range(1, 5);
        _carSprite = Random.Range(0, sprites.Length);

        if (_serit == 1)
        {
            transform.position = new Vector3(-1.45f, transform.position.y + 10, 0);
        }
        else if (_serit == 2)
        {
            transform.position = new Vector3(-0.5f, transform.position.y + 10, 0);
        }
        else if (_serit == 3)
        {
            transform.position = new Vector3(0.5f, transform.position.y + 10, 0);
        }
        else
        {
            transform.position = new Vector3(1.45f, transform.position.y + 10, 0);
        }

        if (sprites.Length > 0)
        {
            _carSprite = Random.Range(0, sprites.Length);
            spr.sprite = sprites[_carSprite];
        }
        else
        {
            UnityEngine.Debug.LogWarning("Sprite dizisi boş!");
        }




    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocityX, _defSpeed * 50 * Time.deltaTime, 0);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "mainCar")
        {
            SceneManager.LoadScene(2);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "puan")
        {
            ScoreManager.skor += 25;
        }
    }
}
