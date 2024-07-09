using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class MainClass
    {
        private DatabaseClass databaseclass = new DatabaseClass();

        private int count_id = 10001;

        private ArrayList items = new ArrayList();
        private ArrayList priceItems = new ArrayList();
        private ArrayList names = new ArrayList();
        private ArrayList id = new ArrayList();


        private StringBuilder stringbuilder = new StringBuilder();
        public bool Check_if_Null(string fname, string uname, string pword, string gender,
            string month, string day, string year)
        {
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(uname) ||
                string.IsNullOrWhiteSpace(pword) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(month) || string.IsNullOrWhiteSpace(day) ||
                string.IsNullOrWhiteSpace(year))
            {
                return true;
            }
            else { return false; }
        }

        public int Create_Id()
        {
            return count_id++;
        }

        public decimal Ordered_Price(decimal item, decimal price)
        {
            return item * price;
        }

        public decimal Total_Price(decimal Item1, decimal item2, decimal Item3, decimal item4,
            decimal Item5, decimal item6, decimal Item7, decimal item8)
        {
            return Item1 + item2 + Item3 + item4 + Item5 + item6 + Item7 + item8;
        }

        public void Store_items(decimal it1, decimal it2, decimal it3, decimal it4, 
            decimal it5, decimal it6, decimal it7, decimal it8)
        {
            items.Add(it1);
            items.Add(it2);
            items.Add(it3);
            items.Add(it4);
            items.Add(it5);
            items.Add(it6);
            items.Add(it7);
            items.Add(it8);
        }

        public void Store_PriceItems(decimal itp1, decimal itp2, decimal itp3, decimal itp4,
            decimal itp5, decimal itp6, decimal itp7, decimal itp8)
        {
            priceItems.Add(itp1);
            priceItems.Add(itp2);
            priceItems.Add(itp3);
            priceItems.Add(itp4);
            priceItems.Add(itp5);
            priceItems.Add(itp6);
            priceItems.Add(itp7);
            priceItems.Add(itp8);
        }

        public void Store_Names(string itn1, string itn2, string itn3, string itn4,
            string itn5, string itn6, string itn7, string itn8)
        {
            names.Add(itn1);
            names.Add(itn2);
            names.Add(itn3);
            names.Add(itn4);
            names.Add(itn5);
            names.Add(itn6);
            names.Add(itn7);
            names.Add(itn8);
        }

        public void Store_Id(int iti1, int iti2, int iti3, int iti4,
            int iti5, int iti6, int iti7, int iti8)
        {
            id.Add(iti1);
            id.Add(iti2);
            id.Add(iti3);
            id.Add(iti4);
            id.Add(iti5);
            id.Add(iti6);
            id.Add(iti7);
            id.Add(iti8);
        }

        public string Receipt_Message(string name, decimal total)
        {
            stringbuilder.Append("CORPORATION XXX \nBLK. 2 LOT 32 XYZ CITY \n+9986443728 \n\nCUSTOMER NAME: " + name + "\n");

            int index = 0;

            foreach (decimal purchased in items)
            {
                if (purchased > 0)
                {
                    stringbuilder.Append("\n" + names[index] + " (X" + purchased + ")\t\t\t" + priceItems[index]);

                    databaseclass.Store_Records((int)id[index], name, (string)names[index], purchased, (decimal)priceItems[index]);

                    databaseclass.updateQuantity((int)id[index], (int)purchased);
                }

                index++;

            }
            stringbuilder.Append("\n----------------------------------------------------------------");
            stringbuilder.Append("\n\nTOTAL:\t\t\t\t" + total);
            string receipt = stringbuilder.ToString();
            
            names.Clear();
            items.Clear();
            priceItems.Clear();
            id.Clear();
            stringbuilder.Clear();
            
            return receipt;

        }

        public decimal Calculate_Payment(decimal due, decimal pay)
        {
            return pay - due;
        }










    }
}
