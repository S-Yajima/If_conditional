using System.Collections.Generic;

public class MessageList {

    private List<string> messageList = new List<string>();

    public MessageList()
    {
        messageList.Add("GameObject�̐F��ς��� bool�^ �̒l true ��Ԃ����\�b�h paint() ������܂��B");
        messageList.Add("������Cube1,Cube2,Cube3�����ꂼ��n����3����s���Ă݂܂��B");
        messageList.Add("Cube��3�Ƃ��F���ς��܂����ˁB");
        messageList.Add("Cube�̐F��߂��܂��B");
        messageList.Add("�ł́Aif���̏������̒��Ń��\�b�h���ĂԂƂǂ��Ȃ�ł��傤�H");
        messageList.Add("���̏ꍇ�ł��ACube��3�Ƃ��F���ς��܂����ˁB");
        messageList.Add("if���̒���3�̏����������ׂĎ��s����܂����B");
        messageList.Add("Cube�̐F��߂��܂��B");
        messageList.Add("if���̘_�����Z�q���u&&�v����u||�v�ɕς��Ď��s����Ƃǂ��ł��傤�H");
        messageList.Add("�ŏ��̏������� paint() ���������s����܂����B");
        messageList.Add("�ŏ���2�Ԗڂ�3�Ԗڂ̏������͎��s����Ȃ������Ƃ������ƂɂȂ�܂��B");
        messageList.Add("if���͍ŏ��̏�������if���S�̂�true�ɂȂ邩false�ɂȂ邩�킩���Ă��܂���");
        messageList.Add("�c��̏������͎��s���Ȃ����Ƃ��킩��܂��ˁB");
        messageList.Add("if���̒��Ń��\�b�h���Ă΂�Ă�����");
        messageList.Add("�ϐ���++�ŃC���N�������g����Ă����肷���");
        messageList.Add("���ӂ��K�v�ȏꍇ������܂��B");
        messageList.Add("�ȏ�Aif���̕����̏������̒��ӓ_�ł����m�V");
    }

    public string getMessage(int index)
    {
        if (messageList.Count == 0 || messageList.Count <= index) return "";

        return messageList[index];
    }
}
