using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    internal static class Core
    {
        public const string KCode = "K3552M5114"; // 배포시 해당 키오스크 번호를 세팅

        public static Panel pMain = null;       //
        public static TextBox TextBox = null;   //



        public static string KName = "";    //키오스크명
        public static decimal KCash = 0;    //키오스크잔액
        public static string Bname = "";    //은행명
        public static Image ADImage = null;


        public static string TRANS_INFO = "";   //거래구분
        public static string PCODE = "";    //고객번호
        public static string NAME = "";     //고객명
        public static string ACODE = "";    //계좌번호//주민등록번호//카드번호//휴대폰번호
        public static string PWD = "";      //계좌비밀번호//카드비밀번호
        public static decimal AMOUNT = 0;   //금액    //입금,출금이면 Cash에서 INOUT이고, 송금이면 ASSET에서 INOUT
        public static decimal TotAsset = 0;


        public static string OTHER_ANAME = "";        //대상계좌주명
        public static string OTHER_BCODE = "";        //대상은행코드
        public static string OTHER_ACODE = "";        //대상은행계좌번호
        public static string OTHER_MSG = "";
        public static decimal FEE = 0;        //수수료
        public static string MSG = "";        //메모


        public static int XID = 0;          //pwd오류횟수
        public static int XPWD = 0;          //pwd오류횟수
        public static string STATUS = "";    //정지계좌유무



        public static string PASS = "정상처리";    //거래결과(정상처리/취소처리)
        public static string STYPE = "거래확인";   //거래확인
        public static string FHCODE = "";   //거래코드

        public static string AdminPwd = "1234"; //관리자비밀번호

    }


}
