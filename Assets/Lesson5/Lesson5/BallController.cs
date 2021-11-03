using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ő�l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�X�R�A
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������Score���擾
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    { 
        //���������ɓ��������Ƃ�
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.scoreText.GetComponent<Text>().text = "score "+ score;
        }
        //�傫�����ɓ��������Ƃ�
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.scoreText.GetComponent<Text>().text = "score " + score;
        }
        //�������܂ɓ��������Ƃ�
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 30;
            this.scoreText.GetComponent<Text>().text = "score " + score;
        }
        //�傫���܂ɓ��������Ƃ�
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 40;
            this.scoreText.GetComponent<Text>().text = "score " + score;
        }

    }
}