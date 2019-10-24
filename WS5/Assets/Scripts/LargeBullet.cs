using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : Bullet //inheritance with Bullet (parent)
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        speed = -3;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
