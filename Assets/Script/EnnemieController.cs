using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnnemieController : BaseClassScript // or CreateEntity (check BaseClass folder)
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
        if (Random.Range(0, 2) == 0)
        {
            DefaultEnemy();
        }
        else
        {
            HardEnemy();
        }
    }

    void DefaultEnemy()
    {
        Health = 1;
        Strength = 10;
        Agility = 1;
        Intelligence = 0;
        Damage = 100;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    void HardEnemy()
    {
        Health = 4;
        Strength = 10;
        Agility = 1;
        Intelligence = 0;
        Damage = 100;
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
                                                 Player.transform.position,
                                                 2f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

}
