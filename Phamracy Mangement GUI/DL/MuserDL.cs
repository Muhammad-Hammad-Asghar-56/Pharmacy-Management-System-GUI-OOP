using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.DL
{
    class MuserDL
    {
        public static List<Muser> usersList = new List<Muser>();
        public static void addInMuserList(Muser item)
        {
            usersList.Add(item);
        }
        public static Muser getMuser(string userName)
        {
            foreach (var i in usersList)
            {
                if (userName == i.getUserName())
                {
                    return i;
                }
            }
            return null;
        }
        //                    geters
        public static Muser getMuser(int index)
        {
            return usersList[index];
        }

        public static int get_MuserListCount()
        {
            return usersList.Count;
        }
        public static List<Muser> getFullMuserList()
        {
            return usersList;
        }
        public static bool IsListEmpty()
        {
            if (usersList.Count <= 0) return true;
            return false;
        }
        public static void Load(string path)
        {
            usersList = new List<Muser>();

            StreamReader file = new StreamReader(path);
            while (true)
            {
                string line = file.ReadLine();
                if (line == "" || line==null)
                {
                    break;
                }
                string[] record = line.Split(',');
                string userName = record[0];
                string userPassword = record[1];
                string passwordHint = record[2];
                string userRole = record[3];
                addInMuserList(new Muser(userName, userPassword, passwordHint, userRole));
            }
            file.Close();
        }
        public static void StoreAccounts(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var i in usersList)
            {
                file.WriteLine("{0},{1},{2},{3}", i.getUserName(), i.getUserPassword(), i.getPasswordHint(), i.getUserRole());
            }
            file.Close();
        }
    }
}
