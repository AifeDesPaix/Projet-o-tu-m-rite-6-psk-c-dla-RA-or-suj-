using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {

    private static bool level1, level2, level3;
	private static bool torche1, torche2;

    public static bool Level1
    {
        get
        {
            return level1;
        }
        set
        {
            level1 = value;
        }
    }

    public static bool Level2
    {
        get
        {
            return level2;
        }
        set
        {
            level2 = value;
        }
    }

    public static bool Level3
    {
        get
        {
            return level3;
        }
        set
        {
            level3 = value;
        }
    }

	public static bool Torche1
	{
		get
		{
			return torche1;
		}
		set
		{
			torche1 = value;
		}
	}

	public static bool Torche2
	{
		get
		{
			return torche2;
		}
		set
		{
			torche2 = value;
		}
	}
}
