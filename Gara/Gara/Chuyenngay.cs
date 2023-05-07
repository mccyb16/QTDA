using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamLop
{
   public class Chuyenngay
    {
       public string ngaynhap(string input)
       {
           string str = input;
           string[] str1 = str.Split('/');
           //str1[0]=27 
           //str1[1]=09 
           //str1[2]=2009 
           //----> "09/27/2009==str1[1] + "/" + str1[0] + "/" + str1[2] 
           string str2 =str1[2] +"-"+ str1[1] + "-" + str1[0];
           return str2;
       }
    }
}
