using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;




public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        {
            // �ϐ�������������
            int d = 3;
            int e = 4;
            // �ϐ�a�ƕϐ�b�̍��v�l��ϐ�c�ɑ������
            int f = d + e;
            // �ϐ�c��\������@
            Debug.Log(f);
        }

        // money��100�ŏ���������
        int money = 100;
        if (money <= 50)
        {
            // money��50�ȉ��������ꍇ�̏���
            Debug.Log("����𔄂�");
        }
        else if (money >= 200)
        {
            // money��200�ȏゾ�����ꍇ�̏���
            Debug.Log("����𔃂�");
        }
        else
        {
            // ����ȊO�̏ꍇ�̏���
            Debug.Log("�|�[�V�����𔃂�");
        }

        int val;
        int num = 1;
        if (num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        Debug.Log(val);


        // �ϐ�a��3�ŏ���������
        int a = 3;
        if (a == 3)
        {
            // �ϐ�a��3�̏ꍇ�A�ϐ�b��5�ŏ���������
            int b = 5;
            // �ϐ�b�̒l��\������
            Debug.Log(b);
        }

        // sum��0�ŏ���������
        int sum = 0;
        // 10�񏈗����J��Ԃ�
        for (int i = 1; i <= 10; i++)
        {
            // i�̒l��sum�ɑ���
            sum += i;
        }
        // sum�̒l��\������
        Debug.Log(sum);

        // �z�������������
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = 0; i < points.Length; i++)
        {
           // �z��̗v�f��50�ȏ�̏ꍇ
           if (points[i] >= 50)
           {
                // �z��̗v�f��\������
                Debug.Log(points[i]);
           }
        }

            //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
            int[] array = { 63, 59, 43, 22, 100 };


            //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(array[i]);
            }

            //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }

    }
    // Update is called once per frame
    void Update()
    {

    }

}
public class kansuu : MonoBehaviour
{
    // �uHello, UnityChan�v�ƕ\������֐�
    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Hello�֐����Ăяo��
        Hello();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Boss
{
    private int hp = 50;   // �̗�
    private int power = 15; // �U����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

}

public class Test2: MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss midboss = new Boss();

        // �U���p�̊֐����Ăяo��
        midboss.Attack();
        // �h��p�̊֐����Ăяo��
        midboss.Defence(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
