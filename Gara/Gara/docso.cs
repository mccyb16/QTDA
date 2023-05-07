using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamLop
{
    public class docso
    {
        public string DocSo(Int64 num)
        {
            string sNum = num.ToString(), temp = "";
            int len = sNum.Length, nhomso;
            string str = "";
            int i = 1;
            while (i <= len)
            {
                str = str + " " + chuso(int.Parse(sNum.Substring(i - 1, 1)));
                nhomso = (int)((len - i) % 9);
                if (i == len) break;
                if (nhomso == 0)
                {
                    str += " tỷ";
                    for (int j = 0; j < 3; j++)
                    {
                        temp = sNum.Substring(i, 3);
                        if (temp == "000")
                            i += 3;
                    }

                }
                else
                    if (nhomso == 6)
                    {
                        str += " triệu";
                        for (int j = 0; j < 2; j++)
                        {
                            temp = sNum.Substring(i, 3);
                            if (temp == "000")
                                i += 3;
                        }
                    }
                    else
                        if (nhomso == 3)
                        {
                            str += " nghìn";
                            temp = sNum.Substring(i, 3);
                            if (temp == "000")
                                i += 3;
                        }
                        else
                        {
                            nhomso = (int)((len - i) % 3);
                            if (nhomso == 2)
                                str += " trăm";
                            else
                                if (nhomso == 1)
                                    str += " mươi";
                        }
                i++;
            }
            str = str.Replace(" không mươi không ", "");
            str = str.Replace(" không mươi ", " linh ");
            str = str.Replace(" mươi không ", " mươi ");
            str = str.Replace(" một mươi ", " mười ");
            str = str.Replace(" mươi bốn ", " mươi tư");
            str = str.Replace(" linh bốn ", " linh tư ");
            str = str.Replace(" mươi một ", " mươi mốt ");
            str = str.Replace(" mươi năm ", " mươi lăm ");
            str = str.Replace(" mười năm ", " mười lăm ");
            str = str.Trim();
            return str;
        }
        private string chuso(int so)
        {
            string kq = "";
            switch (so)
            {
                case 0: kq = "không"; break;
                case 1: kq = "một"; break;
                case 2: kq = "hai"; break;
                case 3: kq = "ba"; break;
                case 4: kq = "bốn"; break;
                case 5: kq = "năm"; break;
                case 6: kq = "sáu"; break;
                case 7: kq = "bảy"; break;
                case 8: kq = "tám"; break;
                case 9: kq = "chín"; break;
            }
            return kq;
        }
    }
}
