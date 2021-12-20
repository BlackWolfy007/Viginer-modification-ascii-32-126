using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Viginer_95
{
    private string Message;

    private string Key;

    public string Get_Message()
    {
        return Message;
    }

    public string Get_Key()
    {
        return Key;
    }

    public void Set_Message(string _message)
    {
        Message = _message;
    }

    public void Set_Key(string _key)
    {
        Key = _key;
    }

    public void Encrypt()
    {
        StringBuilder sb = new StringBuilder();
        int keyLen = Key.Length;

        //for (string temp = Key; temp.Length > 0; keyLen++)
        //{
        //    temp = temp.Substring(0,temp.Length - 1);
        //}

        for (int i = 0, t1, t2; i< Message.Length; i++)
        {
            t2 = keyLen - 1 - i;
            if (t2 < 0)
                t2 = (t2 % keyLen + (keyLen)) % keyLen;
            
            //t1 = Convert.ToInt32(Math.Pow(10, t2));

            //int temporary = (Message[i]);
            //sb.Append(t1);
        }

        //if (key == 0) keyLen++;

    }
}

public class Program
{
    static void Main(string[] args)
    {
        string message = "Hello world!", key = /*"a7@*2b"*/ "!";
        Viginer_95 Encrypt = new Viginer_95();
        Encrypt.Set_Message(message);
        Encrypt.Set_Key(key);
        Encrypt.Encrypt();
    }
}

