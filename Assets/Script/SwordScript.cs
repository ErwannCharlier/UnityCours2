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
}