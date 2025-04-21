namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            // 정수 자료형
            sbyte sbtVal = 127;    // signed byte : -128 ~ 127 수 저장
            System.SByte sbtVal2 = System.SByte.MinValue; // -128 할당
            byte btVal = 255;      // byte : 0 ~ 255 수 저장(1 byte 크기)
            System.Byte btVal2 = System.Byte.MinValue; // 0 할당
            short stVal = 32767;   // short : - 32768 ~ 32767 수 저장
            System.Int16 stVal2 = System.Int16.MinValue; // -32768 할당
            ushort ustVal = 65535;  // unsigned short : 0 ~ 65535 저장(2 byte 크기)
            System.UInt16 ustVal2 = System.UInt16.MinValue; // 0 할당
            int intVal = 2147483647;    // int : -21억 ~ 21억 
            System.Int32 intVal2 = System.Int32.MinValue; // -21억 할당
            uint uintVal = 4294967295;  // unsigned int : 0 ~ 42억 (4 byte 크기)
            System.UInt32 uintVal2 = System.UInt32.MinValue; // 0 할당
            long lngVal = 9000000000000000000; // long : -92경 ~ 92경
            ulong ulngVal = 1800000000000000000; // unsigned long : 18000경 (8 bytes)

            // 실수 자료형
            float fVal = 3.141592f; // float : 4 bytes 소수점
            System.Single fVal2 = System.Single.MinValue; // +-1.5e-45 할당
            double dVal = 3.141592; // double : 8 bytes 소수점
            decimal dcVal = 3.141592m; // decimal : 16 bytes 소수점

            MessageBox.Show(intVal2.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
