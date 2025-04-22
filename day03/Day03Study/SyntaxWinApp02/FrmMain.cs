using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.computer_case;

                    myCom.Boot();
                    myCom.Reset();
                    myCom.ShutDown();
                    break;

                case 1: // Notbook
                    Notbook myBook = new Notbook();
                    PicComputer.Image = Resources.laptop;

                    myBook.Reset();
                    myBook.ShutDown();  // 부모와 다르게 동작

                    //Computer sCom = myBook;
                    // 부모클래스를 자식클래스로 형변환하면서 문제발생 소지
                    //Notbook myBook2 = (Notbook)new Computer();
                    Computer myComputer = new Notbook();

                    if (myComputer is Notbook)
                    {
                        Console.WriteLine("myComputer은 Notbook입니다.");
                        Notbook myBook2 = myComputer as Notbook;
                        Console.WriteLine("myComputer를 Notbook으로 변경!");

                    }

                    // 지문인식확인
                    bool hasFiger = myBook.HasFingerScanDevidce();
                    Console.WriteLine($"최초 지문인식여부 :: {hasFiger}");
                    // 메서드 오버로드
                    hasFiger = myBook.HasFingerScanDevidce(true);
                    Console.WriteLine($"최종 지문인식여부 :: {hasFiger}");
                    break;

                case 2: // Server
                    Server yourServ = new Server();
                    PicComputer.Image = Resources.server;
                    break;

                default:
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();
            //Notbook myNotbook = new Notbook();
            //Server yourServer = new Server();

            //Computer yourCom = new Notbook();   // 부모클래스에 자식 객체를 할당

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP서버";

            // 얕은 복사 : 같은 내용 참조
            Server server2 = server1;
            server2.Name = "DELL서버";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "서버명");

            // 깊은 복사 : 완전 다른객체로 복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "서버명");
        }
    }
}
