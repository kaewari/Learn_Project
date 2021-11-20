using System;
using System.Collections.Generic;
using System.Text;

namespace ChuongTrinhHocTapChoBe.Class
{
    public class StringCustom
    {
        public static string SubstringRight(string str, int soLuongChu)
        {
            string ketQua = str;
            ketQua = ketQua.Substring(str.Length - soLuongChu, soLuongChu);
            return ketQua;
        }
    }
}
