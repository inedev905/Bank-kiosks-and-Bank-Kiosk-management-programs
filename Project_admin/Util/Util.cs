using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_admin
{
    internal static class Util
    {
        private static int gTScnt = 0;
        public static void SetInitDataGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;//DataSource를 기준으로 자동 컬럼을 생성 (기본값이 true)
            dgv.AllowUserToAddRows = false;//마지막에 + 행추가 삭제 (기본값이 true)
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersWidth = 30;
        }

        public static void AddGridTextBoxColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
            bool visible = true,
            bool frosen = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Alignment : 가운데정렬 (길이가 고정적인 경우)
            //Alignment : 왼쪽정렬 (길이가 가변적인 문자열인 경우)
            //Alignment : 오른쪽정렬 (길이가 가변적인 숫자인 경우, 돈, 수량 등)
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;
            col.Visible = visible;
            col.Frozen = frosen;

            dgv.Columns.Add(col);
        }

        public static string GetIDX(string HeadString, int StringLength = 0) // 10자리 권장
        {
            string rtn = "";
            gTScnt += 1;
            Random rad = new Random(gTScnt);
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


        public static string SetMask(string str, int len)
        {
            // str을 len을 제외하고 나머지 마스킹
            string result = string.Empty;

            if (string.IsNullOrEmpty(str) || str.Length <= len) return str;

            else
            {
                result = str.Substring(0, len);
                for (int i = 0; i < str.Length - len; i++)
                {
                    result = string.Concat(result, "*");
                }
            }

            return result;
        }

    }
}