using UnityEngine;
using System.Collections;

public class Enemys
{
    //Static variables are shared across all instances
    //of a class.
    public static int enemyCount = 0;

    public Enemys()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}
