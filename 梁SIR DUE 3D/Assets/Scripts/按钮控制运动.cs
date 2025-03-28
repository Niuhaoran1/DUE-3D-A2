using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 按钮控制运动 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private Vector3 initialPosition; // 存储初始位置

    void Start()
    {
        // 记录物体初始位置
        initialPosition = transform.position;
    }

    public void forward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void back()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    public void left()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    public void right()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    // 新添加的回到初始位置方法
    public void resetPosition()
    {
        transform.position = initialPosition;
    }
}
