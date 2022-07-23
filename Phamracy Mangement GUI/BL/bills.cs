using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phamracy_Mangement_GUI.BL
{
    public class bills
    {
        private int invoiceNo;
        private List<medicine> medicines = new List<medicine>();
        private float actualBill;
        private float discPercent;
        private float payableBill;
        private Muser biller = new Muser();

        internal List<medicine> Medicines { get => medicines; set => medicines = value; }
        public int InvoiceNo { get => invoiceNo; set => invoiceNo = value; }
        public float ActualBill { get => actualBill; set => actualBill = value; }
        public float DiscPercent { get => discPercent; set => discPercent = value; }
        public float PayableBill { get => payableBill; set => payableBill = value; }

        public bills() { }
        public bills(Muser biller, float payableBill)
        {
            this.biller = biller;
            this.PayableBill = payableBill;
        }
        public bills(float payableBill, Muser biller)
        {
            this.PayableBill = payableBill;
            this.biller = biller;
        }
        public bills(List<medicine> medicines, float actualBill, float discPercent, float payableBill, Muser biller)
        {
            this.Medicines = medicines;
            this.ActualBill = actualBill;
            this.DiscPercent = discPercent;
            this.PayableBill = payableBill;
            this.biller = biller;
        }
        
        //-------------------------------------------------------------------------
        //-------------------- setter / getter -------------------------------------
        public void set_Biller(Muser userAccount) => this.biller = userAccount;
        public void set_medicneList(List<medicine> medicines) => this.Medicines = medicines;
        public void set_acutalBill(float actualBill) => this.ActualBill = actualBill;
        public void set_discPercent(float discPercent) => this.DiscPercent = discPercent;
        public void set_payableBill(float payableBill) => this.PayableBill = payableBill;
        public string get_Biller() => biller.getUserName();
        public Muser get_billerObject() => biller;
        public float get_actualBill() => ActualBill;
        public float get_discPersent() => DiscPercent;
        public float get_payableBill() => PayableBill;
        public List<medicine> get_medicinesList() => Medicines;
        public float get_totalbill(float disc)
        {
            float BILL = 0;
            foreach (var i in Medicines)
            {
                BILL = BILL + i.get_price();
            }
            ActualBill = BILL;

            PayableBill = BILL - (disc / 100 * BILL);
            DiscPercent = disc;
            return PayableBill;
        }
        //--------------------------------------------------------------------------
        public void addInBill(medicine sellMedicine, int sellQuantity)
        {
            medicine newmedicine =new medicine();
            newmedicine.set_medicinName(sellMedicine.get_medicinName());
            newmedicine.set_packTabs(sellMedicine.get_packTabs());
            newmedicine.set_price(sellMedicine.get_price() * sellQuantity);
            newmedicine.set_totalQuantity(sellQuantity);
            Medicines.Add(newmedicine);
        }
        public void delteBillAt(int index)
        {
            Medicines.RemoveAt(index);
        }
        public bool isMedicinePresentInList(string medicineName)
        {
            foreach(var i in Medicines)
            {
                if(i.get_medicinName()==medicineName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
