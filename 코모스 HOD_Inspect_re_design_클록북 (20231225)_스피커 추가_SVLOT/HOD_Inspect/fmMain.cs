//아래의 define부분은 #if구문을 사용하기 위한 전처리기 지시문 이다 아래는 사용방법은 프로젝트의 가장 윗부분에 #define 전처리 명령어 를 사용후 #if (전처리 명령)을 입력하면 if문에 해당하는 전처리가
// 실행되도록 한다. 아래는 영문 그리고 scanprint사용시에 대한 전처리기 지시문이 적용된 상태 
//#define SCAN_PRINT  // 울산공장 MX5  수입검사실의경우 , 키보드웨지타입 스케너 사용한다. 다원에서 조립 테스트후 발행한 라벨을 읽어서 검사한다. 
//#define ENGLISH     // 영어 화면 사용
//#define KOMOS_MX5_SIJAK  // 울산공장 시작실의 경우 키보드 웨지타입 건스케너를 사용한다.  시작버턴 누르고 스케너를 읽으면 작업시작, 이후부터 스케너만 읽어도 작업됨. (부저 안울리는 현상이 있으나, 해결?)
//                            --> 큰차이점은 코모스 시작실의 경우, 다원의 검사발행 라벨을 읽어서 검사 완료후 선두문자('K')를 추가한 바코드를 출력한다.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
//*********************************************************************************
   20230915 JHLEE  프로그램통합 ( 영문/한글, 스케너 사용(MX5 수입검사실), 미사용 )
   20230917 JHLEE  ZONE1, ZONE2 검사기능추가
   20231010 JHLEE  수동검사 버턴 추가 (판정않고 표시만)
                   프린터 QR 내용에 품번 추가 , {DateTime.Now.ToString("yyMMdd")}-{S}
                                               내용을 예상해보면,  56111P66700NNB + 230929-00001  , 실제 데이타는 56111P66700NNB23092900001 

   240116 JHLEE    IEE, JOYSON    ,   Check 상태면 IEE 사용이며, ZONE2 검사시 'I2' 전송,  JOYSON  의 경우 'Z2'  전송  


   설치위치 
   1. 다원 (경기도 화성) 2대 (1대는 멀티메터 사용, 1대는 일반사양)
   2. 코모스 화성       1대 MV1라인 (연동)
   3. 코모스 울산       1대 시작실 (키보드 웨지 타입 스케너 사용)
   4. 베트남            2대
   5. 신영테크 (울산)   1대
                   
//*********************************************************************************
*/

namespace HOD_Inspect
{
    using static MAIN;

    public partial class fmMain : Form
    {
        
        private bool END = false;
        private bool Stop_Judge = false;
        private bool Flag = false;
        private bool Start = false;
        private Stopwatch Work_T;
        private string Lot = string.Empty;

        private List<double> CP_List = new List<double>();
        private List<double> D_List = new List<double>();

        
        private bool Hands_ON = false;
        bool CanStartable = false;
        bool Check_Scan = false;

        // 20230917 JHLEE
        private string CP_MIN = "";
        private string CP_MAX = "";
        private string D_MIN = "";
        private string D_MAX = "";
        private int ZoneNo = 0;

        private bool Insp_Manual = false;
        private bool Insp_Manual_Zone1 = false;

        public SoundPlayer OK_SP;
        public SoundPlayer NG_SP;

        public fmMain()
        {
            InitializeComponent();
            txScan.Focus();
            Application.Idle += Application_Idle;
        }

//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ 여기서 부터

        private void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle; // 현 프로그램이 실행되고 대기 상태일때 아래의 전처리기 와 프로그램의 동작들이 실행되도록 하였다.

#if (ENGLISH)
            btnModel.Text = "MODEL";
            btnHistory.Text = "SEARCH";
            // lbtitle 오류로 이름 바꿈
            lbTitle.Text = "HOD INSFECTOR";
            label10.Text = "MODEL NO";
            label13.Text = "MODEL CODE";
            btnModelSet.Text = "ADD";
            btnSpec.Text = "CONFIG";
            label3.Text = "WORK STATUS";
            label4.Text = "RESULT";
            label6.Text = "INSPECTION TIME";
            lbsts.Text = "";
            button1.Text = "END";
            
#else
            btnModel.Text = "모델선택";
            btnHistory.Text = "조회";
            lbTitle.Text = "HOD 검사기";
            label10.Text = "품번";
            label13.Text = "사양";
            btnModelSet.Text = "모델설정";
            btnSpec.Text = "검사설정";
            label3.Text = "작업상태표시";
            label4.Text = "결과표시";
            label6.Text = "측정시간";
            lbsts.Text = "";
            button1.Text = "종료";
#endif


            // JHLEE cSetting.Set 이 무엇인지?
            lbMIN.Text = cSetting.Set.MIN.ToString(); // 각 클래스 해석 필요.
            lbMAX.Text = cSetting.Set.MAX.ToString();

            lb_D_MIN.Text = cSetting.Set.D_MIN.ToString();
            lb_D_MAX.Text = cSetting.Set.D_MAX.ToString();

            // 20230915 JHLEE
            lbMin2.Text = cSetting.Set.MIN2.ToString();
            lbMax2.Text = cSetting.Set.MAX2.ToString();

            lb_D_MIN2.Text = cSetting.Set.D_MIN2.ToString();
            lb_D_MAX2.Text = cSetting.Set.D_MAX2.ToString();
            //

            lb_R_MIN.Text = cSetting.Set.R_MIN.ToString();
            lb_R_MAX.Text = cSetting.Set.R_MAX.ToString();

            OK_SP = new SoundPlayer(Properties.Resources.띵동);
            NG_SP = new SoundPlayer(Properties.Resources.NG);

            if (cSetting.Set.LCRUSE)
                panel3.Visible = true;
            else
                panel3.Visible = false;


                SCAN.vReceive += SCAN_vReceive;

// 아래 구문은 람다형식으로 Thread를 별도 실행시키기 위한구문 - 하나의 프로그램이 실행되는 동안 다른 프로그램들이 같이 실행되도록 하는 형식의 구문?
            new Thread(() =>
            {
                Stopwatch ReadDb = Stopwatch.StartNew();
                while(Running)
                {
                    Thread.Sleep(1); // 과도한 cpu사용을 막기 위한 장치적 제어적 측면의 구문
                    //if (M.Count == 0) continue;
                    if (!cCublock.ISOPEN) return; // cublock이 열리지 않으면 리턴 cublock실행이 되어 있어야만 프로그램 동작

                    // CUBLUCK 과 연결된 시작 버턴을 누르면 Status == "START" 상태이다.

                    try
                    {
                        // 20230917 Status 값 디버깅용
                        this.UI(() =>
                        {
#if ENGLISH
                            lbTitle.Text = $"HOD INSPECTOR {Status}";
#else
                            lbTitle.Text = $"HOD 검사기 {Status}";
#endif
                        });

#if (SCAN_PRINT)
                        if (Status == "GO" && !Check_Scan)    // 키보드웻지 타입 스케너 동작시 (구체적으로 txScan.text 에 문자가 입력되면) Status 가 GO 가 된다.
                        {
                            //this.UI(() =>
                            //{
                            //    //txScan.Text = "";  // 20230920 jhlee 여기코드 지우는것 , 울산현장은 사용한다. 확인할것.
                            //    txScan.Focus();   // MX5 수입검사실의 스케너는 키보드웨지타입임 (통신타입이아님)
                            //    txScan.Focus();
                            //    txScan.Focus();
                            //});
                            Check_Scan = true;
                        }

                        if (Status == "GO" || Status == "Z2" && !END && ModelSelection)
#else
                        if (Status == "START" || Insp_Manual == true || Status == "Z2" || Status == "I2" && !END && ModelSelection)
#endif
                        {
                            //cMKPLC.SetWriteAdd("M0005", 0);
                            //cMKPLC.SetWriteAdd("M0006", 0);

                            if (!Flag)
                            {
                                Flag = true;

                                // 20231010 JHLEE
                                if (Insp_Manual == false)
                                {
                                    Work_T = Stopwatch.StartNew();
                                }

                                DataTable DT_LOT = SQL.GetLotNo();
                                DataRow R = DT_LOT.Rows[0];
                                Lot = R["LOT"].ToString().PadLeft(5, '0');

                                CP_List.Clear();
                                D_List.Clear();


                                // 20230917 20231010 JHLEE 
                                if (Insp_Manual == false)
                                {
                                    ZoneNo = 1;
                                }

                                this.UI(() =>
                                {
                                    lb_J.Text = "-";
                                    lb_J.BackColor = Color.LightSlateGray;
                                    lbVal.Text = "-";
                                    lbD_Val.Text = "-";

                                    // 20230917 JHLEE
                                    lbVal2.Text = "-";
                                    lbD_Val2.Text = "-";
                                    
                                    lbR_Val.Text = "-";
                                    ssT.Value = cSetting.Set.Work_Time.ToString();
                                });

                                if (cSetting.Set.LCRUSE)
                                    cLCR.Read();
                            }

                            this.UI(() =>
                            {
#if (ENGLISH)
                                lbsts.Text = "INSPECTION...";
#else
                                lbsts.Text = "측정중...";
#endif

                                if (Insp_Manual == true)
                                {
                                    ssT.Value = $"{Work_T.Elapsed.Seconds}";
                                }
                                else
                                {
                                    ssT.Value = $"{cSetting.Set.Work_Time - Work_T.Elapsed.Seconds}";
                                }
                                
                            });

                            LCR_SET.Reset();
                            LCR.SendData();

                            if (LCR_SET.WaitOne(1000))
                            {
                                // 20230917 JHLEE
                                if (ZoneNo == 1)
                                {
                                    this.UI(() =>
                                    {
                                        // ZONE1 데이타 표시
                                        lbVal.Text = MT_V.ToString();
                                        lbD_Val.Text = MT_D.ToString();
                                    });
                                }
                                else
                                {
                                    this.UI(() =>
                                    {
                                        // ZONE2 데이타 표시
                                        lbVal2.Text = MT_V.ToString();
                                        lbD_Val2.Text = MT_D.ToString();
                                    });

                                }

                                // 20231010 JHLEE 수동측정시 판정 및 저장 안하게....
                                //if (Insp_Manual == false)
                                //{ 
                                    // ZONE1 데이타 리스트 저장
                                    CP_List.Add(MT_V);
                                    D_List.Add(MT_D);

                                if (Insp_Manual == false)
                                { 
                                    // 20230917 JHLEE   여기서는 ZONE1, ZONE2 검사 구분 한다.
                                    if (ZoneNo == 1 )
                                    {
                                        // MIN MAX  측정
                                        if (MT_V > lbMIN.Text.ToDouble() && lbMAX.Text.ToDouble() > MT_V && MT_D > lb_D_MIN.Text.ToDouble() && lb_D_MAX.Text.ToDouble() > MT_D)
                                        {
                                            // 20230918 JHLEE
                                            //if (Math.Abs(CP_List.Min() - CP_List.Max()) > 2)   // cSetting.Set.MIN_V
                                            if (Math.Abs(CP_List.Min() - CP_List.Max()) > cSetting.Set.MIN_V)
                                            {

                                                Hands_ON = true;
                                                this.UI(() =>
                                                {
                                                    lb_J.Text = $"{Math.Abs(CP_List.Min() - CP_List.Max()):0}";
                                                });
                                            }
                                            else
                                            {

                                                Hands_ON = false;
                                            }
                                        }
                                        else  // MIN MAX 벗어나면 NG 처리
                                        {
                                            this.UI(() =>
                                            {
                                                lb_J.Text = $"ZONE1 NG";
                                                lb_J.BackColor = Color.Red;

                                                NG_SP.Play();
                                                // 20230915 JHLEE
                                                //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", "", "NG");
                                                //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", "", "", "", "", "", "NG");
                                                //SQL.SaveDataSecond("NG", $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"");


                                                txScan.Text = "";
                                                END = true;
                                                cCublock.Write("NG");
                                                Status = "NG";
                                            });
                                        }
                                    }
                                    else
                                    {
                                        // ZONE2 검사

                                        // MIN MAX  측정
                                        if (MT_V > lbMin2.Text.ToDouble() && lbMax2.Text.ToDouble() > MT_V && MT_D > lb_D_MIN2.Text.ToDouble() && lb_D_MAX2.Text.ToDouble() > MT_D)
                                        {
                                            //Stop_Judge = true;
                                            if (Math.Abs(CP_List.Min() - CP_List.Max()) > cSetting.Set.MIN_V)
                                            {

                                                Hands_ON = true;

                                                this.UI(() =>
                                                {
                                                    lb_J.Text = $"{Math.Abs(CP_List.Min() - CP_List.Max()):0}";
                                                });
                                            }
                                            else
                                            {

                                                Hands_ON = false;
                                            }
                                        }
                                        else  // MIN MAX 벗어나면 NG 처리
                                        {
                                            this.UI(() =>
                                            {
                                                lb_J.Text = $"ZONE2 NG";
                                                lb_J.BackColor = Color.Red;

                                                NG_SP.Play();
                                                // 20230915 JHLEE
                                                // Zone 통합
                                                //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", "", "NG");
                                                // Zone1, 2 구분 저장
                                                //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, CP_MIN, CP_MAX, D_MIN, D_MAX, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", "", "NG");
                                                //SQL.SaveDataSecond("NG", $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"");


                                                txScan.Text = "";
                                                END = true;
                                                cCublock.Write("NG");
                                                Status = "NG";
                                            });
                                        }
                                    }

                                }
                            }

                            if (Work_T.Elapsed.Seconds >= cSetting.Set.Work_Time && Insp_Manual == false)
                            {
                                //END = true;
                                if (ZoneNo == 1)
                                {
                                    if (((MT_R > lb_R_MIN.Text.ToDouble() && lb_R_MAX.Text.ToDouble() > MT_R) || !cSetting.Set.LCRUSE) && Hands_ON)
                                    {
                                        this.UI(() =>
                                        {
                                            lbCNT.Text = CP_List.Count().ToString();
                                            lb_J.Text = "ZONE1 OK";
                                            lb_J.BackColor = Color.Lime;
                                            //lbR_Val.Text = cSetting.Set.LCRUSE ? $"{MT_R}" : "0.0";
                                            // 20231010 JHLEE 저항측정 저장, 저항없는곳은 "" 저장토록
                                            lbR_Val.Text = cSetting.Set.LCRUSE ? $"{MT_R}" : "";

                                            OK_SP.Play();

                                            // 20230915 JHLEE 전체 OK  는 ZONE2 검사후 저장한다. 아래는 주석처리
                                            // 20230917 JHLEE saveData 를 실행하면 r_History 에 실적이 추가되고, 카운터를 하여 Lot 를 생성 시킨다.( Lot = 생산수 )
                                            //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}", "OK");

                                            //if (cSetting.Set.PrintUSE)
                                            //{
                                            //   BPrint.DoPrint($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, SelCar, lbSpec.Text);
                                            //}


                                            //CP_MIN = CP_List.Min().ToString();
                                            CP_MIN = $"{CP_List.Min()}";
                                            CP_MAX = $"{CP_List.Max()}";
                                            D_MIN = $"{D_List.Min()}";
                                            D_MAX = $"{D_List.Max()}";

                                            if (Insp_Manual_Zone1 == false)
                                            {
                                                ZoneNo = 2;
                                                Task.Delay(500);

                                                if (Maker.Text == "IEE")                          // JHLEE 240116 IEE. JOYSON
                                                    cCublock.Write("I2");
                                                else
                                                    cCublock.Write("Z2");

                                                Task.Delay(1000);
                                                Work_T = Stopwatch.StartNew();
                                            }

                                            CP_List.Clear();
                                            D_List.Clear();
                                        });

                                    }
                                    //********************************************************************************************************

                                    else
                                    {
                                        this.UI(() =>
                                        {
                                            lb_J.Text = Hands_ON ? $"NG" : "1 HANDS ON NG!";
                                            lb_J.BackColor = Color.Red;
                                            lbR_Val.Text = $"{MT_R}";

                                            // 20230915 JHLEE , HANDS ON NG는 데이타 저장하지 않는다.
                                            //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}", "NG");

                                            txScan.Text = "";
                                            END = true;
                                            cCublock.Write("NG");
                                            Status = "NG";
                                            NG_SP.Play();
                                        });
                                    }

                                }
                                else
                                {   // ZONE2

                                    END = true;
                                    if (((MT_R > lb_R_MIN.Text.ToDouble() && lb_R_MAX.Text.ToDouble() > MT_R) || !cSetting.Set.LCRUSE) && Hands_ON)
                                    {
                                        this.UI(() =>
                                        {
                                            lbCNT.Text = CP_List.Count().ToString();
                                            lb_J.Text = "ZONE2 OK";
                                            lb_J.BackColor = Color.Lime;
                                            //lbR_Val.Text = cSetting.Set.LCRUSE ? $"{MT_R}" : "0.0";
                                            lbR_Val.Text = cSetting.Set.LCRUSE ? $"{MT_R}" : "";

                                            OK_SP.Play();
                                            // 20230917 JHLEE saveData 를 실행하면 r_History 에 실적이 추가되고, 카운터를 하여 Lot 를 생성 시킨다.( Lot = 생산수 )
                                            // 20230922 JHLEE 저장할때 바코드 읽은것 저장해야 하지 않을까???????
                                            
#if (KOMOS_MX5_SIJAK)
                                            SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", txScan.Text, CP_MIN, CP_MAX, D_MIN, D_MAX, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}", "OK");
#else
                                            SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, CP_MIN, CP_MAX, D_MIN, D_MAX, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}", "OK");
#endif
                                            if (cSetting.Set.DbCheck)
                                            {
                                                //SQL.SaveDataSecond("OK", $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}");
                                                SQL.SaveDataSecond("OK", CP_MIN, CP_MAX, D_MIN, D_MAX, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}");
                                            }

                                            if (cSetting.Set.PrintUSE)
                                            {

                                                // 20230920 JHLEE 울산현장에서 다원 바코드 읽은것 바코드에 "K" 추가한 라벨 출력 토록함.
#if (KOMOS_MX5_SIJAK)
                                                BPrint.DoPrint($"{DateTime.Now.ToString("yyMMdd")}{Lot}", txScan.Text, SelCar, lbSpec.Text);
#else
                                                BPrint.DoPrint($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, SelCar, lbSpec.Text);
#endif
                                                
                                               
                                            }
                                        });

                                        //********************************************************************************************************
                                        //여기서 2번째 검사를 시작한다.
                                        // 시작시간 재셋팅
                                        ZoneNo = 0;
                                        

                                        cCublock.Write("OK");
                                        Status = "OK";
                                    }
                                    //********************************************************************************************************

                                    else
                                    {
                                        this.UI(() =>
                                        {
                                            lb_J.Text = Hands_ON ? $"NG" : "2 HANDS ON NG!";
                                            lb_J.BackColor = Color.Red;
                                            lbR_Val.Text = $"{MT_R}";

                                            // 20230915 JHLEE , HANDS ON NG는 데이타 저장하지 않는다.
                                            //SQL.SaveData($"{DateTime.Now.ToString("yyMMdd")}{Lot}", lbPartNo.Text, $"{CP_List.Min()}", $"{CP_List.Max()}", $"{D_List.Min()}", $"{D_List.Max()}", $"{MT_R}", "NG");



                                            txScan.Text = "";
                                            cCublock.Write("NG");
                                            Status = "NG";

                                            NG_SP.Play();
                                        });
                                    }
                                }

                            }

                        }
#if (SCAN_PRINT)
                        else if (Status == "GO" && !END && !ModelSelection)
#else
                        else if (Status == "START" && !END && !ModelSelection)
#endif
                        {
                            END = true;
                            this.UI(() =>
                            {
#if (ENGLISH)
                                lb_J.Text = $"MODEL SELECT!";
#else
                                lb_J.Text = $"모델 선택!";
#endif
                                lb_J.BackColor = Color.Orange;
                            });
                            cCublock.Write("NG");

                        }
#if (SCAN_PRINT)
                        else if ((Status != "GO" && END) || (Status == "RESET" && !END))
#else
                        else if ((Status != "START" && END) || (Status == "RESET" && !END))
#endif
                        {
                            ZoneNo = 0;
                            //Stop_Judge = false;
                            END = false;
                            Flag = false;
                            Check_Scan = false;
                            MT_V = 0;
                            MT_D = 0;
                            MT_R = 0;
                            txScan.Text = "";

                            // 20231010 JHLEE
                            btnManual.Enabled = true;
                            btnManual2.Enabled = true;

                            // 20231010 JHLEE  수동 Zone1 검사후 종료사 자동으로 Zone2 검사 넘어가는것 방지 Flag 
                            Insp_Manual_Zone1 = false;

                            this.UI(() =>
                            {
#if (ENGLISH)
                                lbsts.Text = "DONE";
#else
                                lbsts.Text = "측정 종료";
#endif
                            });
                        }
                       
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine(se.Message);
                    }
                }

                cCublock.Close();
                //BPrint.Close();
                LCR.Disconnect();
                cLCR.DisConnect();
                this.UI(() => { this.Close(); }); 
            }).Start();
        }

        private void SCAN_vReceive(string obj)
        {
            this.UI(() => 
            {
                txScan.Text = obj;
            });
            Status = "GO";
        }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ 여기까지 수정

        internal void ModelChange(string car ,string PartNo)
        {
            DataTable DT = SQL.GetModel(car, PartNo);
            if(DT != null && DT.Rows.Count > 0)
            {
                DataRow R = DT.Rows[0];
                ModelSelect = true;
                this.UI(() =>
                {
                    lbPartNo.Text = R["PartNo"].ToString();
                    lbSpec.Text = R["SPEC"].ToString();
                    lb_J.Text = "-";
                    lb_J.BackColor = Color.LightSlateGray;
                    lbVal.Text = "-";
                    lbD_Val.Text = "-";
                    lbR_Val.Text = "-";

                    // 20230915 JHLEE
                    lbVal2.Text = "-";
                    lbD_Val2.Text = "-";
                   
                    //
                    ssT.Value = cSetting.Set.Work_Time.ToString();
                });

                DataTable Spec_DT = SQL.GetCarSpec(MAIN.SelCar);
                if(Spec_DT != null && Spec_DT.Rows.Count > 0)
                {
                    DataRow SP = Spec_DT.Rows[0];
                    this.UI(() => 
                    {
                        lbMIN.Text = SP["CP_MIN"].ToString();
                        lbMAX.Text = SP["CP_MAX"].ToString();

                        lb_D_MIN.Text = SP["D_MIN"].ToString();
                        lb_D_MAX.Text = SP["D_MAX"].ToString();

                        // 20230915 JHLEE
                        lbMin2.Text = SP["CP_MIN2"].ToString();
                        lbMax2.Text = SP["CP_MAX2"].ToString();

                        lb_D_MIN2.Text = SP["D_MIN2"].ToString();
                        lb_D_MAX2.Text = SP["D_MAX2"].ToString();
                        //

                        lb_R_MIN.Text = SP["R_MIN"].ToString();
                        lb_R_MAX.Text = SP["R_MAX"].ToString();

                        Maker.Text = SP["Maker"].ToString();       // 240116 JHLEE IEE, JOYSON dddw
                    });
                }
            }
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAIN.SelCar))
            {
#if ENGLISH
                MessageBox.Show("Chcking Model Select!");
#else
                MessageBox.Show("차종을 선택 해 주십시오!");
#endif
                return;
            }
            fmSpec fs = new fmSpec();
            fs.ShowDialog();

            DataTable Spec_DT = SQL.GetCarSpec(MAIN.SelCar);
            if (Spec_DT != null && Spec_DT.Rows.Count > 0)
            {
                DataRow SP = Spec_DT.Rows[0];
                this.UI(() =>
                {
                    lbMIN.Text = SP["CP_MIN"].ToString();
                    lbMAX.Text = SP["CP_MAX"].ToString();

                    lb_D_MIN.Text = SP["D_MIN"].ToString();
                    lb_D_MAX.Text = SP["D_MAX"].ToString();

                    // 20230915 JHLEE
                    lbMin2.Text = SP["CP_MIN2"].ToString();
                    lbMax2.Text = SP["CP_MAX2"].ToString();

                    lb_D_MIN2.Text = SP["D_MIN2"].ToString();
                    lb_D_MAX2.Text = SP["D_MAX2"].ToString();
                    //

                    lb_R_MIN.Text = SP["R_MIN"].ToString();
                    lb_R_MAX.Text = SP["R_MAX"].ToString();

                    Maker.Text = SP["Maker"].ToString();       // 240116 JHLEE IEE, JOYSON
                });
            }

            //lbMIN.Text = cSetting.Set.MIN.ToString();
            //lbMAX.Text = cSetting.Set.MAX.ToString();

            //lb_D_MIN.Text = cSetting.Set.D_MIN.ToString();
            //lb_D_MAX.Text = cSetting.Set.D_MAX.ToString();

            //lb_R_MIN.Text = cSetting.Set.R_MIN.ToString();
            //lb_R_MAX.Text = cSetting.Set.R_MAX.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Running = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LCR.SendData();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            fmModelSel fms = new fmModelSel();
            fms.Show();
        }

        private void btnModelSet_Click(object sender, EventArgs e)
        {
            fmModelSetcs fmset = new fmModelSetcs();
            fmset.Show();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            fmHistory fmh = new fmHistory();
            fmh.Show();
        }

        private void label14_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL.ResetDb();
        }

        private void lb_R_MAX_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txScan_KeyUp(object sender, KeyEventArgs e)
        {

            // 20230917 JHLEE   그냥 바코드 읽으면 Go 를 보내는데, 사양확인을 하고 맞으면 Go를 보내도록 수정.

            /*int Li_Length = txScan.Text.Length;

            if (Li_Length >= lbPartNo.Text.Length)
            {
                if (string.Compare(lbPartNo.Text, txScan.Text, true) == 0)
                {
                    Status = "GO";
                }
                else
                {
                    lb_J.Text = txScan.Text;
                    lb_J.BackColor = Color.Red;
                }
            }
            */
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.LineFeed)
                Status = "GO";
        }

        private void txScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (!Insp_Manual)
            {
                Work_T = Stopwatch.StartNew();
                Insp_Manual_Zone1 = true;
                Insp_Manual = true;
                btnManual.Text = "Z1수동";
                btnManual2.Text = "Z2대기";
                ZoneNo = 1;
                cCublock.Write("OK");
            }
           
            else
            {
                Insp_Manual = false;

                btnManual.Text = "Z1대기";
                cCublock.Write("OK");
                
            }
            
        }

        private void btnManual2_Click(object sender, EventArgs e)
        {
            if (!Insp_Manual)
            {
                Work_T = Stopwatch.StartNew();
                Insp_Manual = true;
                btnManual2.Text = "Z2수동";
                btnManual.Text = "Z1대기";
                ZoneNo = 2;
                cCublock.Write("OK");
                Task.Delay(1000);
                cCublock.Write("Z2");
                Insp_Manual_Zone1 = false;
            }
            
            else
            {
               
                Insp_Manual = false;
                btnManual2.Text = "Z2대기";
                cCublock.Write("OK");
            }
            
        }

        private void Maker_Click(object sender, EventArgs e)
        {

        }
    }
}
