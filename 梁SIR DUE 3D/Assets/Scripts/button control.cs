using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 按钮控制运动 : MonoBehaviour
{
    // 原有移动控制部分
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

    // ====== 新增的旋转控制部分 ======
    [Header("旋转设置")]
    [Tooltip("旋转速度(度/秒)")]
    public float rotationSpeed = 30f; // 默认旋转速度

    // 向左旋转
    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    // 向右旋转
    public void RotateRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}