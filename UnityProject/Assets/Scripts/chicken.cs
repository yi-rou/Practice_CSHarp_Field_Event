using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳躍高度"),Range(10,999)]
	public int jump = 19;
	[Header("走路速度"),Range(1.5f,99.9f)]
	public float speed = 4.5f;
	[Tooltip("是否取得食物")]
	public bool food;

}
