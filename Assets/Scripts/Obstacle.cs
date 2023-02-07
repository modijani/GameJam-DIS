using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    public float damage;

    void Start()
    {
        setDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    abstract protected void setDamage();


}
