using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : Obstacle
{

    protected override void setDamage()
    {
        damage = 15;
    }
}
