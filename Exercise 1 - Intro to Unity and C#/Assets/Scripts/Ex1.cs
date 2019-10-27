using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    int min = 10;
    int max = 80;
    int no = 50;
    int ud = 1;
    int lr = 10;

    public void updown()
    {
        if(Input.GetKeyDown("up"))
        {
            no++; // OR no = no + ud;
            print("Number = " + no);
        }

        else if(Input.GetKeyDown("down"))
        {
            no--; // OR no = no - ud;
            print("Number = " + no);
        }
    }

    public void leftright()
    {
        if(Input.GetKeyDown("left"))
        {
            no = no - lr;
            print("Number = " + no);
        }

        else if(Input.GetKeyDown("right"))
        {
            no = no + lr;
            print("Number = " + no);
        }
    }

    public void minmax()
    {
        if (no <= min)
        {
            print("Number has reached minimum ");
            UnityEditor.EditorApplication.isPlaying = false;
        }

        else if (no >= max)
        {
            print("Number has reached maximum ");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        print("The number is 50");
    }

    // Update is called once per frame
    void Update()
    {
        updown();
        leftright();
        minmax();
    }
}
