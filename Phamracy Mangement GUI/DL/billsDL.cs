using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.DL
{
    class billsDL
    {
        private static List<bills> billHistory = new List<bills>();
        public static void addInBillList(bills item)
        {
            item.InvoiceNo = billHistory.Count + 1;
            billHistory.Add(item);
        }
        //                    geters
        public static bills get_BillListItem(int count)
        {
            count--;
            return billHistory[count];
        }

        public static int get_BillListCount()
        {
            return billHistory.Count;
        }
        public static List<bills> getFullBillList()
        {
            return billHistory;
        }
        public static bool IsListEmpty()
        {
            if (billHistory.Count <= 0) return true;
            return false;
        }
        public static List<bills> getMedinceByBiller(string userName)
        {
            List<bills> newList = new List<bills>();
            newList = billHistory.Where(m => m.get_Biller() == userName).ToList();
            return newList;
        }
        public static List<bills> getMedinceByMedicine(string medicineName)
        {
            List<bills> newList = new List<bills>();
            foreach (var i in billHistory)
            {
                if (i.isMedicinePresentInList(medicineName))
                {
                    newList.Add(i);
                }
            }
            return newList;
        }
        public static void Load(string path)
        {
            billHistory = new List<bills>();
            StreamReader file = new StreamReader(path);
            while (true)
            {
                string line = file.ReadLine();
                if (line==null || line == "")
                {
                    break;
                }

                bills newbill = new bills();
                string[] record = line.Split(',');
                newbill.set_Biller(MuserDL.getMuser(record[0]));
                newbill.set_acutalBill(float.Parse(record[1]));
                newbill.set_discPercent(float.Parse(record[2]));
                newbill.set_payableBill(float.Parse(record[3]));
                if (record.Length > 3 &&(record[4] != null || record[4] != " "))
                {
                    List<medicine> medicineList = populateMedicineList(record[4]);// only products sets
                    medicineList = populateMedicineQuantity(medicineList, record[5]);//   quantity sets
                    newbill.set_medicneList(medicineList);
                }
                addInBillList(newbill);
            }
            file.Close();
        }
        public static List<medicine> populateMedicineQuantity(List<medicine> medicineList, string line)
        {
            string[] record = line.Split(';');
            for (int i = 0; i < medicineList.Count; i++)
            {
                medicineList[i].set_totalQuantity(int.Parse(record[i]));
            }
            return medicineList;
        }
        public static List<medicine> populateMedicineList(string line)
        {
            string[] record = line.Split(';');
            List<medicine> medicineList = new List<medicine>();
            foreach (var i in record)
            {
                medicine newMedicine = medicineDL.get_medicineListItem(i);
                if (newMedicine != null)
                {
                    medicineList.Add(newMedicine);
                }
            }
            return medicineList;
        }
        public static void StoreBills(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var i in billHistory)
            {
                file.Write("{0},{1},{2},{3},", i.get_Biller(), i.get_actualBill(), i.get_discPersent(), i.get_payableBill());
                if (i.get_medicinesList().Count > 0)
                {
                    writeMedicine(file, i.get_medicinesList());
                    file.Write(",");
                    writeMedicineQuantities(file, i.get_medicinesList());
                    file.WriteLine();
                }
            }
            file.Flush();
            file.Close();
        }
        public static void writeMedicineQuantities(StreamWriter file, List<medicine> medicines)
        {
            for (int i = 0; i < medicines.Count; i++)
            {

                file.Write(medicines[i].get_totalQuantity());
                if (i < medicines.Count - 1) { file.Write(";"); }
            }
        }
        public static void writeMedicine(StreamWriter file, List<medicine> medicines)
        {
            for (int i = 0; i < medicines.Count; i++)
            {

                file.Write(medicines[i].get_medicinName());
                if (i < medicines.Count - 1) { file.Write(";"); }
            }
        }
        public static bills getMinimiumBill()
        {
            float smallest = billHistory[0].get_payableBill();
            bills minimumBill = billHistory[0];
            if (billHistory.Count > 0)
            {
                foreach (var i in billHistory)
                {

                    if (smallest > i.get_payableBill())
                    {
                        smallest = i.get_payableBill();
                        minimumBill = i;
                    }
                }
            }
            return minimumBill;
        }
        public static bills getMaximiumBill()
        {
            float largest = billHistory[0].get_payableBill();
            bills minimumBill = billHistory[0];
            if (billHistory.Count > 0)
            {
                foreach (var i in billHistory)
                {

                    if (largest < i.get_payableBill())
                    {
                        largest = i.get_payableBill();
                        minimumBill = i;
                    }
                }
            }
            return minimumBill;
        }
        public static float getTotalActualBills()
        {
            float sum = (from x in billHistory select x.ActualBill).Sum();
            return sum;
        }
        public static float getTotaldiscount()
        {
            float sum = (from x in billHistory select x.DiscPercent).Sum();
            return sum;
        }
        public static float getTotalPayBills()
        {
            float sum = (from x in billHistory select x.PayableBill).Sum();
            return sum;
        }
    }
}
