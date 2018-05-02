using UnityEngine;
using System.Collections;



public class BluePlayerController : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;

    //プレイヤーを移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;

    //移動するための力
    private float forwardForce = 10.0f;

    // Use this for initialization
    void Start()
    {

        //Animatorコンポーネントを取得
        this.myAnimator = GetComponent<Animator>();

        //Rigidbodyコンポーネントを取得
        this.myRigidbody = GetComponent<Rigidbody>();

    }
    void Update()
    {

        //プレイヤーを矢印で移動させる
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //後ろに移動
            this.myRigidbody.AddForce(-this.forwardForce, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //前に移動
            this.myRigidbody.AddForce(this.forwardForce, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //左に移動
            this.myRigidbody.AddForce(0, 0, this.forwardForce);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //右に移動
            this.myRigidbody.AddForce(0, 0, this.forwardForce);
        }
    }
}