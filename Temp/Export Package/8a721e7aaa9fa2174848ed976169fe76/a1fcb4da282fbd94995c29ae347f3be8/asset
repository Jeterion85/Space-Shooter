/*using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class savemanager 
{
    public savedata sd;

    public static void save(int pm)
    {
        string path = Application.persistentDataPath + "/shooter.save";
        if (File.Exists(path))
        {
            updatesave(pm);
        }
        else
        {
            newsave(pm);
        }
    }

    public static void updatesave(int pm)
    {
        string path = Application.persistentDataPath + "/shooter.save";
        FileStream stream = new FileStream(path, FileMode.Append);
        var finalscore = pm;

        //xml way
        var sz = new XmlSerializer(typeof(savedata));
        sz.Serialize(stream, pm);

        // binary way
         /*BinaryFormatter formatter = new BinaryFormatter();                
         formatter.Serialize(stream, finalscore);
         stream.Close();
    }

    public static void newsave(int pm)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shooter.save";
        FileStream stream = new FileStream(path, FileMode.Create);
        var finalscore =  pm;

        formatter.Serialize(stream, finalscore);
        stream.Close();
    }

    public static int load()
    {
        string path = Application.persistentDataPath + "/shooter.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            int finalscore = (int)formatter.Deserialize(stream);
            stream.Close();            
            return finalscore;
        }
        else
        {
            Debug.Log("savenotfound");
            return 0;
        }
    }

}

public class savedata
{
    public int[] scores;
}*/
