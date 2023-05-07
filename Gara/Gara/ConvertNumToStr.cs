using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamLop
{
    public class ConvertNumToStr{
    private string[] strSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        /* đoạn này lấy từ chương trình của bạn đã đưa lên 
        private string[] strDonViNho = { "linh", "lăm", "mười", "mươi", "mốt", "trăm" };
        private string[] strDonViLon = { "", "ngàn", "triệu", "tỷ" };*/
        int a, b, c;
        //Tạo một mảng chuỗi, mỗi chuỗi có độ dài 3 ký tự
        public string[] slipArray(string input)
        {
            int i=0;
            string[] strArray;
            int length = input.Length;
            if(length%3==0)//Nếu chỗi chia hết cho 3 thì lấy độ dài bằng phần nguyên
                strArray = new string[length / 3];
            else//Nếu chỗi không chia hết cho 3 thì lấy độ dài bằng phần nguyên+1
                strArray = new string[length / 3+1];
            if (length < 3)
                strArray[0] = input;
            else
            {
                while (length >= 3)
                {
                    strArray[i] = input.Remove(0, length - 3);
                    input = input.Remove(length - 3, 3);
                    i++;
                    length = length - 3;
                }
                if (length > 0)
                    strArray[i] = input;
            }
            return strArray;
        }
        public string converNumToString(string[] list)
        {

            int i;
            string results="";
            int length = list.Length;
            if (length <= 4)
            {
                if (length == 1)
                    results=readThousand(list[0]);
                if (length == 2)
                    results = readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                if(length==3)
                    results = readThousand(list[2]) + " triệu " + readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                if (length == 4)
                    results = readThousand(list[3]) + " tỷ " + readThousand(list[2]) + " triệu " + readThousand(list[1]) + " nghìn " + readThousand(list[0]);
            }
            if (length > 4)
            {
                string[] strArray1= new string[3];
                string[] strArray2 = new string[length-3];
                for (i = 0; i < 3; i++)
                {
                    strArray1[i] = list[i];
                }
                for (i = 0; i < length - 3; i++)
                {
                    strArray2[i] = list[3 + i];
                }
                //Gọi đệ quy
                results = converNumToString(strArray2) + " tỷ " + converNumToString(strArray1);
            }
            return results;
        }
        //hàm đọc một chuỗi có 3 chữ số ra chữ
        public string readThousand(string input)
        {
            string output = "";
            input = input.Trim();
            string numStr = input;
            int length = numStr.Length;
            if (length == 1)
                output = strSo[Convert.ToInt32(input)];
            if (length == 2)
            {
                a = Convert.ToInt32(Convert.ToString(numStr[0]));
                b= Convert.ToInt32(Convert.ToString(numStr[1]));
                if (a != 1)
                    if (b!= 5)
                        output = strSo[a] + " mươi " + readThousand(Convert.ToString(numStr[1]));
                    else
                        output = strSo[a] + " mươi lăm";
                if (a == 1)
                    if (b != 5)
                        output = "mười " + readThousand(Convert.ToString(numStr[1]));
                    else
                        output = "mười lăm";
            }
            if (length == 3)
            {
                a = Convert.ToInt32(Convert.ToString(numStr[0]));
                b = Convert.ToInt32(Convert.ToString(numStr[1]));
                c = Convert.ToInt32(Convert.ToString(numStr[2]));
                if(b==0)
                    output=strSo[a]+" trăm linh "+readThousand(Convert.ToString(numStr[2]));
                else
                    output = strSo[a] +" trăm "+ readThousand(Convert.ToString(numStr[1]) + Convert.ToString(numStr[2]));
            }
            return output;
        }
        public string ngaynhap(string input)
        {
            string str = input;
            string[] str1 = str.Split('/');
            //str1[0]=27 
            //str1[1]=09 
            //str1[2]=2009 
            //----> "09/27/2009==str1[1] + "/" + str1[0] + "/" + str1[2] 
            string str2 = str1[2] + "-" + str1[1] + "-" + str1[0];
            return str2;
        }
    }
}
