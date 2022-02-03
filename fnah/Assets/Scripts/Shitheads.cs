using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shitheads : MonoBehaviour
{
    public enum ShitheadType { Rain, Isaac, Preston, Harry};
    public ShitheadType shitheadName;
    public static int rainDiff;
    public static int isaacDiff;
    public static int presDiff;
    public static int harryDiff;
    public int location;
    public Transform[] locations;
    
}
