using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanPho.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int idbill, int idfood, int count)
        {
            this.ID = id;
            this.IdBill = idbill;
            this.IdFood = idfood;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.IdFood = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

        private int count;
        public int Count { get => count; set => count = value; }

        private int iD;
        public int ID { get => iD; set => iD = value; }

        private int idBill;
        public int IdBill { get => idBill; set => idBill = value; }

        private int idFood;
        public int IdFood { get => idFood; set => idFood = value; }

    }
}
