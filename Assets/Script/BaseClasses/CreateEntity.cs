using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEntity : BaseClassScript
{
    public CreateEntity()
    {
        ClassName = "Entity";
        Health = 10;
        Strength = 5;
        Intelligence = 2;
        Agility = 3;
        Damage = Strength * Intelligence;
        canShoot = false;
    }
}
