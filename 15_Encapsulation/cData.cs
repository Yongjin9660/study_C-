using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Encapsulation
{
    partial class cData
    {
        private string _strItem = string.Empty;
        private int iRate = 0;
        private int iCount = 0;

        public string StrItem { get => _strItem; 
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                    _strItem = value;
            }
            
        }
        private string _strErrorName = string.Empty;

        public int IRate { 
            get => iRate;
            set
            {
                if (value > 20)
                {
                    _strErrorName = "사장님만 가능한 할인입니다.";
                }
                else
                {
                    iRate = value;
                }
            }
        }
        public int ICount { 
            get => iCount;
            set
            {
                if (value > 5)
                    _strErrorName = "개별 물품은 5개 이상 살 수 없습니다.";
                else if (value == 0)
                    _strErrorName = "물품의 개수가 0개입니다.";
                else
                    iCount = value;
            }
        }

        public string StrErrorName { get => _strErrorName; //set => _strErrorName = value; 
        }
    }
    partial class cData
    {
        public double fItemPrice()
        {
            double dPrice = 0;
            int iItemPrice = 0;
            if (String.IsNullOrEmpty(_strErrorName))
            {
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);
                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)iRate / 100, 2);
            }
            return dPrice * iCount;
        }
    }
    partial class cData
    {
        public string fResult(double dPrice)
        {
            if (IRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", _strItem, ICount, dPrice);
            }
            else
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", _strItem, ICount, dPrice, IRate);
        }
    }

}
