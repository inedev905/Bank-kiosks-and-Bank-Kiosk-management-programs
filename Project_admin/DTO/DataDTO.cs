using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_admin
{
    public class CustomerDTO
    {
        // 고객관련
        public string Pcode { get; set; }
        public string Bcode { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Nbr { get; set; }

        public string Email { get; set; }
        public string Zip { get; set; }
        public string Addr { get; set; }
        public string Addrs { get; set; }
    }


    public class AccountDTO
    {
        // 계좌관련
        public string Acode { get; set; }    //ACODE
        public string Pcode { get; set; }

        public string Pwd { get; set; } //PWD
        public decimal Asset { get; set; }
        public bool Status { get; set; }    //STATUS
        public string CardNo { get; set; }     //CARD_NO
        public string CardPwd { get; set; }    //CARD_PWD
    }


    public class BankDTO
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string Name { get; set; }
        public decimal Cash { get; set; }
        public decimal Asset { get; set; }
        public string PWD { get; set; }
        public int SUM { get; set; }
    }


    public class KioskDTO
    { //KCODE, BCODE, NAME, AD_IMAGE, BACK_IMAGE, CASH, CDATE
        public string KCODE { get; set; }
        public string BCODE { get; set; }
        public string NAME { get; set; }
        public Image AD_IMAGE { get; set; }
        public Image BACK_IMAGE { get; set; }
        public decimal CASH { get; set; }
    }
}
