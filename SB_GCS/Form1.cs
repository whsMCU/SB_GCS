using SB_GCS.Class;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace SB_GCS
{
    public partial class Form1 : Form
    {
        UTF8 UTF8 = new UTF8();

        float[] attitude = new float[4];
        DataPassing data = new DataPassing();

        GraphPane attitude_graph = new GraphPane();
        LineItem line_roll;
        LineItem line_pitch;
        LineItem line_yaw;
        PointPairList pointRoll = new PointPairList();
        PointPairList pointPitch = new PointPairList();
        PointPairList pointYaw = new PointPairList();

        Int32 cnt = 0;
        public Form1()
        {
            InitializeComponent();

            // clear old curves
            attitude_graph.CurveList.Clear();

            attitude_graph.Title.Text = "EXAMPLE FOR ZEDGRAPH";
            //exampleGraphPane.Title.IsVisible = false;//그래프 타이틀이 보기싫으면 false. default는 true;

            attitude_graph.XAxis.Title.Text = "Time (1s)";
            attitude_graph.XAxis.Scale.MinorStep = 1;    //작은 눈금 
            attitude_graph.XAxis.Scale.MajorStep = 10;   //큰 눈금
            attitude_graph.XAxis.Scale.Min = 0;
            //attitude_graph.XAxis.Scale.Max = 100;
            attitude_graph.YAxis.Title.Text = "Angle";
            attitude_graph.YAxis.Scale.MinorStep = 1;
            attitude_graph.YAxis.Scale.MajorStep = 10;
            attitude_graph.YAxis.Scale.Min = -100;
            attitude_graph.YAxis.Scale.Max = 100;

            /**********눈금 색**********/
            attitude_graph.XAxis.MajorTic.Color = Color.Orange;
            attitude_graph.YAxis.MajorTic.Color = Color.Orange;

            attitude_graph.XAxis.Type = AxisType.Linear;
            line_roll = attitude_graph.AddCurve("Roll_Angle", pointRoll, Color.Yellow, SymbolType.None);
            line_pitch = attitude_graph.AddCurve("Pitch_Angle", pointPitch, Color.Blue, SymbolType.None);
            //line_yaw = attitude_graph.AddCurve("Yaw_Angle", pointYaw, Color.White, SymbolType.None);

            attitude_graph.XAxis.MajorGrid.IsVisible = true;
            attitude_graph.YAxis.MajorGrid.IsVisible = true;
            attitude_graph.XAxis.MajorGrid.Color = Color.White;
            attitude_graph.YAxis.MajorGrid.Color = Color.White;

            //attitude_graph.XAxis.ResetAutoScale(attitude_graph, CreateGraphics());
            //attitude_graph.YAxis.ResetAutoScale(attitude_graph, CreateGraphics());

            attitude_graph.Chart.Fill = new Fill(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
        }

        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 115200;  //보레이트 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                serialPort1.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
                timer1.Start();
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            //int ReceiveData = serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //richTextBox_received.Text = richTextBox_received.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
            try
            {
                int iRecSize = serialPort1.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize != 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        serialPort1.Read(buff, 0, iRecSize);
                        attitude = data.dataRecive(buff, iRecSize);
                        text_roll.Text = attitude[0].ToString();
                        text_pitch.Text = attitude[1].ToString();
                        text_yaw.Text = attitude[2].ToString();
                        data.dataRecive(buff, iRecSize);

                        if (this.CB_Enable_Terminal.Checked && this.radioButton_ASCII.Checked)
                        {
                            string strTemp = this.UTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);
                            TextBox_received.AppendText(strTemp);
                        //if (objSaveFile != null)
                        //    objSaveFile.Write(strTemp);

                        }

                        if (this.CB_Enable_Terminal.Checked && this.radioButton_HEX.Checked)
                        {
                            TextBox_received.AppendText(BitConverter.ToString(buff).Replace("-", " ") + " ");
                        }
                    }
                    catch { }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            serialPort1.Write(textBox_send.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
        }

        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pointRoll.Add(cnt, attitude[0]);
            pointPitch.Add(cnt, attitude[1]);
            //pointYaw.Add(cnt, attitude[2]);

            cnt++;
            if(cnt % 10000 == 1)
            {
                pointRoll.Clear();
                pointPitch.Clear();
            }

            //attitude_graph.XAxis.ResetAutoScale(attitude_graph, CreateGraphics());
            //attitude_graph.YAxis.ResetAutoScale(attitude_graph, CreateGraphics());

            //zedGraphControl1.Refresh();

            attitude_graph.AxisChange();
        }
    }
}
