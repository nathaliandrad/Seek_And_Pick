using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : Object
{
    public static bool isHolding = false;
    public static int boxResistance =5;
    public static int health = 5;
    public static int jumpCount = 0;
    public static int maxJump = 1;

    public static int tableResistance = 8;
    public static int hammerResistance = 15;
    public static int knifeResistance = 10;

    public static bool canEnemyShoot = false;

    public static bool runOn = false;

    public static bool sharp, round, square = false;

}
