using System.Collections.Generic;

public class MessageList {

    private List<string> messageList = new List<string>();

    public MessageList()
    {
        messageList.Add("GameObjectの色を変えて bool型 の値 true を返すメソッド paint() があります。");
        messageList.Add("引数にCube1,Cube2,Cube3をそれぞれ渡して3回実行してみます。");
        messageList.Add("Cubeが3つとも色が変わりましたね。");
        messageList.Add("Cubeの色を戻します。");
        messageList.Add("では、if文の条件式の中でメソッドを呼ぶとどうなるでしょう？");
        messageList.Add("この場合でも、Cubeが3つとも色が変わりましたね。");
        messageList.Add("if文の中の3つの条件式がすべて実行されました。");
        messageList.Add("Cubeの色を戻します。");
        messageList.Add("if文の論理演算子を「&&」から「||」に変えて実行するとどうでしょう？");
        messageList.Add("最初の条件式の paint() だけが実行されました。");
        messageList.Add("最初の2番目と3番目の条件式は実行されなかったということになります。");
        messageList.Add("if文は最初の条件式でif文全体がtrueになるかfalseになるかわかってしまうと");
        messageList.Add("残りの条件式は実行しないことがわかりますね。");
        messageList.Add("if文の中でメソッドが呼ばれていたり");
        messageList.Add("変数が++でインクリメントされていたりすると");
        messageList.Add("注意が必要な場合があります。");
        messageList.Add("以上、if文の複数の条件式の注意点でしたノシ");
    }

    public string getMessage(int index)
    {
        if (messageList.Count == 0 || messageList.Count <= index) return "";

        return messageList[index];
    }
}
