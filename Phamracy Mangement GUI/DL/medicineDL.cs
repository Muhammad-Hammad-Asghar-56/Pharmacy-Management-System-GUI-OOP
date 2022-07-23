using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.DL
{
    class medicineDL
    {
        private static List<medicine> stockList = new List<medicine>();

        internal static List<medicine> StockList { get => stockList; set => stockList = value; }

        public static void set_INList(medicine item, int index)
        {
            StockList[index] = item;
        }
        public static medicine getInMedicineList(string medincineName)
        {
            foreach(var i in StockList)
            {
                if(medincineName==i.get_medicinName())
                {
                    return i;
                }
            }
            return null;
        }
        public static void addInmedicineList(medicine newMewdicine)
        {
            StockList.Add(newMewdicine);
        }
        //                    geters
        public static medicine get_medicineListItem(int index)
        {
            return StockList[index];
        }
        public static medicine get_medicineListItem(string medicineName)
        {
            foreach (var i in StockList)
            {
                if (medicineName == i.get_medicinName()) { return i; }
            }
            return null;
        }
        public static void removeInList(int index)
        {
            StockList.RemoveAt(index);
        }
        public static int get_MedicineListCount()
        {
            return StockList.Count;
        }
        public static List<medicine> getFullStockList()
        {
            return StockList;
        }
        public static bool IsListEmpty()
        {
            if (StockList.Count <= 0) return true;
            return false;
        }
        public static medicine getcheapestItem()
        {
            int largest = 0, index = 0;

            if (!IsListEmpty())
            {
                largest = StockList[0].get_price();

                for (int i = 0; i < StockList.Count; i++)
                {
                    if (largest > StockList[i].get_price())
                    {
                        largest = StockList[i].get_price();
                        index = i;
                    }
                }
            }
            return StockList[index];
        }
        
        public static void storeStock(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach(var i in StockList)
            {
                file.WriteLine("{0},{1},{2},{3}", i.get_medicinName(), i.get_packTabs(), i.get_price(), i.get_totalQuantity());
            }
            file.Flush();
            file.Close();
        }
        public static List<medicine> getThresholdQuantity(int limit)
        {
            return stockList.Where(c=> c.get_totalQuantity() < limit).ToList(); 
        }
        public static void loadStock(string path)
        {
            stockList = new List<medicine>();
            StreamReader file = new StreamReader(path);
            while(true)
            {
                string line = file.ReadLine();
                if(line=="" || line==null)
                {
                    break;
                }
                string[] record = line.Split(',');
                medicine newMedicine = new medicine(record[0], int.Parse(record[1]), int.Parse(record[2]), int.Parse(record[3]));
                StockList.Add(newMedicine);
            }
            file.Close();
        }
        public static int getPriceTotal()
        {
            int sum = (from x in stockList select x.get_price()).Sum();
            return sum;
        }
    }
}
