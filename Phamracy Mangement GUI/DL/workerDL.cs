using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.DL
{
    class workerDL
    {
        public static List<worker> workerList = new List<worker>();
        //                       seters
        public static void set_INList(worker item, int index)
        {
            workerList[index] = item;
        }
        public static void addInWorkerList(worker item)
        {
            workerList.Add(item);
        }
        //                    geters
        public static worker get_WorkerListItem(int index)
        {
            return workerList[index];
        }
        public static void removeInList(int index)
        {
            workerList.RemoveAt(index);
        }
        public static int get_WorkerListCount()
        {
            return workerList.Count;
        }
        public static List<worker> getFullWorkerList()
        {
            return workerList;
        }
        public static bool IsListEmpty()
        {
            if (workerList.Count <= 0) return true;
            return false;
        }
        public static void Load(string path)
        {
            workerList = new List<worker>();
            StreamReader file = new StreamReader(path);
            while (true)
            {
                string line = file.ReadLine();
                if (line == null||line ==" ")
                {
                    break;
                }
                string[] record = line.Split(',');
                string name = record[0];
                int age = int.Parse(record[1]);
                string post = record[2];
                string religion = record[3];
                int salary = int.Parse(record[4]);
                addInWorkerList(new worker(salary, age, name, religion, post));
            }
            file.Close();
        }
        public static void StoreWorkers(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var i in workerList)
            {
                file.WriteLine("{0},{1},{2},{3},{4}", i.PersonName, i.Age, i.Post, i.Religion, i.Salary);
            }
            file.Flush();
            file.Close();
        }
    }
}
