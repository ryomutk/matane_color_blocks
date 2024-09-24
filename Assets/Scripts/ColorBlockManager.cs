using UnityEngine;


public class ColorBlockManager : MonoBehaviour
{
    Block[] blocks;
    Ball ball;

    void Start()
    {
        blocks = GetComponentsInChildren<Block>();
        ball = GetComponentInChildren<Ball>();
    }
}