using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    Animation anim;
    public int Damage;

    void Start()
    {
        anim = GetComponent<Animation>();
        GameObject Player = GameObject.Find("Player");
        Damage = Player.GetComponent<BaseClassScript>().Damage;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {
            var EnemyClass = collision.gameObject.GetComponent<BaseClassScript>();
            EnemyClass.Health -= Damage;
            if (EnemyClass.Health == 2)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            if (EnemyClass.Health <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
