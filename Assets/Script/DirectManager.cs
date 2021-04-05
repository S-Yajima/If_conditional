using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class DirectManager : MonoBehaviour
{
    [SerializeField] private GameObject cube1;
    [SerializeField] private GameObject cube2;
    [SerializeField] private GameObject cube3;
    [SerializeField] private GameObject code_text;
    [SerializeField] private GameObject message_text;
    private SourceCodeList codes = new SourceCodeList();
    private MessageList messages = new MessageList();
    private int code_text_number = 0;
    private int message_text_number = 0;


    void resetColor()
    {
        cube1.GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 0f, 1.0f);
        cube2.GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 0f, 1.0f);
        cube3.GetComponent<Renderer>().material.color = Color.HSVToRGB(0f, 0f, 1.0f);
    }

    void paintAll()
    {
        if (paint(cube1) == true && paint(cube2) == true && paint(cube3) == true)
        {
            Debug.Log("PaintAll");
        }
    }

    void paintCube1()
    {
        if (paint(cube1) == true || paint(cube2) == true || paint(cube3) == true)
        {
            Debug.Log("PaintCube1");
        }
    }

    bool paint(GameObject obj) {
        obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);
        return true;
    }

    void setCodeText()
    {
        code_text.GetComponent<TextMeshProUGUI>().text = codes.getMessage(code_text_number);
        code_text_number++;
    }

    void setMessageText()
    {
        message_text.GetComponent<TextMeshProUGUI>().text = messages.getMessage(message_text_number);
        message_text_number++;
    }


    // Start is called before the first frame update
    void Start() 
    {
        float invoke_time = 1f;
        float add_time = 5f;

        Invoke("setCodeText", invoke_time);                             // �� paint�֐��̂݁i���j
        Invoke("setMessageText", invoke_time); invoke_time += add_time;
        Invoke("setCodeText", invoke_time);                             // �� paint�֐���Start�i�j��paint�������s�i���F/�����j�j
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //������Cube1,Cube2,Cube3�����ꂼ��n����3����s���Ă݂܂��B

        Invoke("paintAll", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //Cube��3�Ƃ��F���ς��܂�����

        Invoke("resetColor", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //Cube�̐F��߂��܂��B

        Invoke("setCodeText", invoke_time);                             // �� paint�֐���Start�i�j��if()���i����1,����2,����3 ���F�j
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //�ł́Aif���̏������̒��Ń��\�b�h���ĂԂƂǂ��Ȃ�ł��傤�H");

        Invoke("paintAll", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // ���̏ꍇ��Cube��3�Ƃ��F���ς��܂����ˁB
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if���̒���3�̏����������ׂĎ��s����܂����B

        Invoke("resetColor", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // Cube�̐F��߂��܂��B

        Invoke("setCodeText", invoke_time);                             // �� paint�֐���Start�i�j��if()�� ( || ���F �j
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if���̘_�����Z�q���u&&�v����u||�v�ɕς��Ď��s����Ƃǂ��ł��傤�H

        Invoke("paintCube1", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // �ŏ��̏������� paint() ���������s����܂����B
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // �ŏ���2�Ԗڂ�3�Ԗڂ̏������͎��s����Ȃ������Ƃ������ƂɂȂ�܂��B

        Invoke("setCodeText", invoke_time);                             // �� paint�֐���Start�i�j��if()���i����1 ���F ||�j
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if���͍ŏ��̏�������if���S�̂�true�ɂȂ邩false�ɂȂ邩�킩���Ă��܂���

        Invoke("setCodeText", invoke_time);                             // �� paint�֐���Start�i�j��if()���i����2,3 ���F ||�j
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // �c��̏������͎��s���Ȃ����Ƃ��킩��܂��ˁB
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if���̒��Ń��\�b�h���Ă΂�Ă�����
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // �ϐ���++�ŃC���N�������g����Ă����肷���
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // ���ӂ��K�v�ȏꍇ������܂��B
        Invoke("setMessageText", invoke_time); invoke_time += add_time;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
