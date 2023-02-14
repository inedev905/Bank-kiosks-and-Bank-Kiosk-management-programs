using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Util
    {
        private static int gTScnt = 0;

        public static string Tns()
        {
            string sRtn = "";
            switch (Core.TRANS_INFO)
            {
                case "TNS01":
                    sRtn = "입금";
                    break;

                case "TNS02":
                    sRtn= "출금";
                    break;

                case "TNS03":
                    sRtn = "송금";
                    break;

                case "TNS04":
                    sRtn = "무통장입금";
                    break;

                case "TNS05":
                    sRtn = "계좌이력조회";
                    break;

                case "TNS06":
                    sRtn = "관리자 현금입금";
                    break;
                case "TNS07":
                    sRtn = "관리자 현금인출";
                    break;
            };

            return sRtn;
        }


        public static byte[] ImageToByte(Image image)
        {
            if (image == null)
                return null;

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image ByteToImage(byte[] bytes)
        {
            if (bytes == null)
                return null;

            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            return Image.FromStream(ms, true);
        }


        public static string GetIDX(string HeadString, int StringLength = 0) // 10자리 권장
        {
            string rtn = "";
            gTScnt += 1;
            Random rad = new Random();  //(gTScnt)
            int ts1 = rad.Next(1000, 9999);
            int ts2 = DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;

            rtn = HeadString + ts1.ToHex(32) + ts2.ToHex(32) + gTScnt.ToHex(32) + gTScnt.ToHex(32);

            // 길이 가공
            if (StringLength > 0)
            {
                if (rtn.Length > StringLength)
                    rtn = rtn.Substring(0, StringLength);
                else if (rtn.Length < StringLength)
                {
                    do
                    {
                        rtn += ALPHANUMERIC.Substring(rad.Next(1, 32), 1); // 모자라는 길이 만금 임의의 문자 생성
                    } while (rtn.Length < StringLength);
                }
            }

            return rtn;
        }

        private static readonly string ALPHANUMERIC = "0123456789" +        // ~ 10
                                     "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + // ~ 36
                                     "abcdefghijklmnopqrstuvwxyz";  // ~ 62

        /// <summary>
        /// 10진수(DEC)를 진수(HEX)로 변환
        /// </summary>
        /// <param name="DEC">DEC</param>
        /// <param name="N">진수</param>
        /// <returns></returns>
        public static string ToHex(this int DEC, int N = 16)
        {
            return ToHex(long.Parse(DEC.ToString()), N);
        }

        /// <summary>
        /// 10진수(DEC)를 진수(HEX)로 변환
        /// </summary>
        /// <param name="DEC">DEC</param>
        /// <param name="N">진수</param>
        /// <returns></returns>
        public static string ToHex(this long DEC, int N = 16)
        {
            if (N > ALPHANUMERIC.Length)
                return "";

            string baseChars = ALPHANUMERIC.Substring(0, N);
            string r = string.Empty;
            int targetBase = baseChars.Length;
            do
            {
                r = string.Format("{0}{1}",
                    baseChars[(int)(DEC % targetBase)],
                    r);
                DEC /= targetBase;
            } while (DEC > 0);

            return r;
        }
    }
}
/* static을 쓰는이유
 * 키오스크프로그램은 동시에 여러화면에 프로그램이 동작하지않는다.
 * 한 화면에 한개의 프로그램만 작동된다.
 * 그리고 그 창은 이미 넘어 간 상태라 다른 입력사항이 더이상 없음. 이미 그 변수 값은 고정
 * 
 * 변수의 값이 동시에 다른 프로그램이 접근하는 일이 없음
 * 
*/