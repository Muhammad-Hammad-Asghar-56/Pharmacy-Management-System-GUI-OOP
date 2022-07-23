using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phamracy_Mangement_GUI.BL
{
    public class medicine
    {
        private string medicineName;
        private int price;
        private int totalQuantity;
        private int packTabs;

        public string MedicineName { get => medicineName; set => medicineName = value; }
        public int Price { get => price; set => price = value; }
        public int TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public int PackTabs { get => packTabs; set => packTabs = value; }

        //---------------------------------------------------------------------------------------
        public void set_medicinName(string medicineName) => this.MedicineName = medicineName;
        public void set_price(int price) => this.Price = price;
        public void set_totalQuantity(int totalQuantity) => this.TotalQuantity = totalQuantity;
        public void set_packTabs(int packTabs) => this.PackTabs = packTabs;
        //---------------------------------------------------------------------------------------
        public string get_medicinName() => MedicineName;
        public int get_price() => Price;
        public int get_totalQuantity() => TotalQuantity;
        public int get_packTabs() => PackTabs;

        //---------------------------------------------------------------------------------------
        public void sellMedicineAmount(int sellMedicineAmount)
        {
            TotalQuantity = TotalQuantity - sellMedicineAmount;
        }
        public void UpdateMedicine(medicine UpdatesMedicine)
        {
            this.medicineName = UpdatesMedicine.MedicineName;
            this.PackTabs = UpdatesMedicine.packTabs;
            this.Price = UpdatesMedicine.price;
            this.TotalQuantity = totalQuantity + UpdatesMedicine.TotalQuantity;
        }
        public medicine() { }
        public medicine(string medicineName,int packQuantity,int price,int totalQuantity)
        {
            this.MedicineName = medicineName;
            this.PackTabs = packQuantity;
            this.Price = price;
            this.TotalQuantity = totalQuantity;
        }
        public bool IsQuantityPresent(int amount)
        {
            if (amount <= TotalQuantity) { return true; }
            return false;
        }
    }
}
