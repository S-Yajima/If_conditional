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

        Invoke("setCodeText", invoke_time);                             // ◆ paint関数のみ（白）
        Invoke("setMessageText", invoke_time); invoke_time += add_time;
        Invoke("setCodeText", invoke_time);                             // ◆ paint関数とStart（）でpaint順次実行（水色/下線））
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //引数にCube1,Cube2,Cube3をそれぞれ渡して3回実行してみます。

        Invoke("paintAll", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //Cubeが3つとも色が変わりましたね

        Invoke("resetColor", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //Cubeの色を戻します。

        Invoke("setCodeText", invoke_time);                             // ◆ paint関数とStart（）でif()文（条件1,条件2,条件3 黄色）
        Invoke("setMessageText", invoke_time); invoke_time += add_time; //では、if文の条件式の中でメソッドを呼ぶとどうなるでしょう？");

        Invoke("paintAll", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // この場合もCubeが3つとも色が変わりましたね。
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if文の中の3つの条件式がすべて実行されました。

        Invoke("resetColor", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // Cubeの色を戻します。

        Invoke("setCodeText", invoke_time);                             // ◆ paint関数とStart（）でif()文 ( || 黄色 ）
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if文の論理演算子を「&&」から「||」に変えて実行するとどうでしょう？

        Invoke("paintCube1", invoke_time);
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // 最初の条件式の paint() だけが実行されました。
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // 最初の2番目と3番目の条件式は実行されなかったということになります。

        Invoke("setCodeText", invoke_time);                             // ◆ paint関数とStart（）でif()文（条件1 黄色 ||）
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if文は最初の条件式でif文全体がtrueになるかfalseになるかわかってしまうと

        Invoke("setCodeText", invoke_time);                             // ◆ paint関数とStart（）でif()文（条件2,3 水色 ||）
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // 残りの条件式は実行しないことがわかりますね。
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // if文の中でメソッドが呼ばれていたり
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // 変数が++でインクリメントされていたりすると
        Invoke("setMessageText", invoke_time); invoke_time += add_time; // 注意が必要な場合があります。
        Invoke("setMessageText", invoke_time); invoke_time += add_time;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
