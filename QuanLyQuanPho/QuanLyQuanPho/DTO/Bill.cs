using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanPho.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? DateCheckIn, DateTime? DateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];

            var dataCheckOutTemp = row["DateCheckOut"];
            if(dataCheckOutTemp.ToString() != "")
            { this.DateCheckOut = (DateTime?)dataCheckOutTemp; }
           
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        private int discount;
        public int Discount { get => discount; set => discount = value; }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }


        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        private int iD;
        public int ID { get => iD; set => iD = value; }

        private int status;
        public int Status { get => status; set => status = value; }
        
    }
}
