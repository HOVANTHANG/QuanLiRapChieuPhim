using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_RapChieuPhim.Database
{
    internal class Function_SinhMaTuDong
    {
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();
        public string SinhMaTuDong(string TenBang, char KyTuTienTo, string TruongMa)
        {
            int id = 1;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (!dung)
            {
                ma = KyTuTienTo + id.ToString().PadLeft(3, '0');
                dm = dataBase.DataRead("Select * from " + TenBang + " where " + TruongMa + "='" + ma + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                }
            }
            return ma;
        }

        public string SinhMoi(string maCuoi)
        {
            int soCuoi = int.Parse(maCuoi.Substring(1));
            soCuoi++;
            string maMoi = maCuoi[0] + soCuoi.ToString().PadLeft(3, '0');
            return maMoi;
        }



    }
}
