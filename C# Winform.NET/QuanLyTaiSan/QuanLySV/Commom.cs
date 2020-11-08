using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class Commom
    {
        public static int clone_nguoi_quen = 13;




        public static string getMoneyStr(string Money)
        {
            if (Money == string.Empty || Money == null)
                return "";
            float fmoney = float.Parse(Money);

            decimal decimal_value = Math.Round(Convert.ToDecimal(fmoney), 2);

            string[] listStr = decimal_value.ToString().Split('.');

            char[] listChar = listStr[0].ToCharArray(); // 1 - 2

            string result = "";
            int count = 0;
            for (int i = listChar.Length - 1; i >= 0; i--)
            {
                if (count % 3 == 0 && count != 0)
                {
                    result += "," + listChar[i];
                }
                else
                {
                    result += listChar[i];
                }
                count++;
            }



            if (listStr.Length == 1)
            {
                return Reverse(result) + " ";
            }
            else
            {
                return Reverse(result) + "." + listStr[1] + " ";
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        public static Image getImage(string img)
        {
            return Image.FromFile("../../icon/" + img);
        }
    }
}
