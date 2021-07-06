using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class savemanagernew 
{
    public int scores;
    // Start is called before the first frame update
    public static void save(int[] score)
    {
        string serializedData = null;
        for (int i = 0; i < score.Length; i++)
        {
            serializedData += score[i].ToString() + "\n";
        }
            string path = Application.persistentDataPath + "/shooter.txt";

            // Write to disk
            StreamWriter writer = new StreamWriter(path, false);
            writer.Write(serializedData);
            writer.Close();
        
    }

    public static void checkfile()
    {
        string path = Application.persistentDataPath + "/shooter.txt";
        if (!File.Exists(path))
        {
            StreamWriter writer = new StreamWriter(path, false);            
            writer.Close();
        }
    }

    public static string[] load()
    {
        // Read
        string path = Application.persistentDataPath + "/shooter.txt";

        StreamReader reader = new StreamReader(path);
        string line = reader.ReadToEnd();       
        string[] scores = line.Split('\n');
        reader.Close();

        return scores;
    }

    // Update is called once per frame
    public static void Check()
    {
        string path = Application.persistentDataPath + "/shooter.txt";
        if (File.ReadLines(path).Count() >6)
        {
            Debug.Log(">6");
            int []savelist = bubblesort();
        }
        else
        {
            Debug.Log("<6");
            int[] savelist =  bubblesort();
        }
    }

    public static void add(int score)
    {
        int[] savelist = bubblesort();
        int temp;
        for(int i = 0; i < savelist.Length - 1; i++)
        {
            if(savelist[i] < score)
            {
                temp = savelist[i];
                savelist[i] = score;
                score = temp;
                Debug.Log(temp);
            }
        }
        save(savelist);
    }

    public static int[] bubblesort()
    {
        string[] savelist = load();
        int[] array = {0,0,0,0,0,0};

        for (int i = 0; i < savelist.Length-1; i++)
        {
            array[i] = int.Parse(savelist[i]);
            Debug.Log("int");
        }

        int temp;
        for (int j = 0; j <= array.Length - 2; j++)
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] < array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                    Debug.Log("bubble");
                }
            }
        }
        return array;
    }
}
