using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetSDKCS;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;    
//程序开头的using语句用于导入命名空间。命名空间提供了一种组织代码和防止命名冲突的方法。

namespace RealPlayAndPTZDemo
//该程序定义了一个名为RealPlayAndPTZDemo的新命名空间。在这个命名空间中，有一个名为“RealPlayAndPTZDemo”的类，它扩展了Form类。
{
    public partial class RealPlayAndPTZDemo : Form
    {
        #region Field 字段    //本节为RealPlayAndPTZDemo类定义了几个字段(变量)。
        private const int m_WaitTime = 5000;
        private const int SyncFileSize = 5* 1024 *1204;
        private static fDisConnectCallBack m_DisConnectCallBack;     //委托类型的静态变量
        private static fHaveReConnectCallBack m_ReConnectCallBack;
        private static fRealDataCallBackEx2 m_RealDataCallBackEx2;
        private static fSnapRevCallBack m_SnapRevCallBack;

        private IntPtr m_LoginID = IntPtr.Zero;     //m_LoginID是一个类型为IntPtr(一个指针)的变量，最初设置为IntPtr. zero
        private NET_DEVICEINFO_Ex m_DeviceInfo;     //m_DeviceInfo是一个NET_DEVICEINFO_Ex类型的变量(一个自定义结构)
        private IntPtr m_RealPlayID = IntPtr.Zero;  //同m_LoginID，m_RealPlayID是一个IntPtr类型的变量，最初也被设置为IntPtr.Zero
        private uint m_SnapSerialNum = 1;
        private bool m_IsInSave = false;
        private int SpeedValue = 4;
        private const int MaxSpeed = 8;
        private const int MinSpeed = 1;
        #endregion

        public RealPlayAndPTZDemo()   //这是“RealPlayAndPTZDemo”类的构造函数
        {
            InitializeComponent();    //它调用InitializeComponent()函数，该函数负责初始化表单及其组件
            this.Load += new EventHandler(RealPlayAndPTZDemo_Load);   //事件处理程序注册语句，它将一个事件处理程序函数与表单的Load事件关联起来，这意味着当表单加载时，RealPlayAndPTZDemo_Load函数将被执行
            //this.Load指向RealPlayAndPTZDemo表格的Load事件
            //+=是事件订阅操作符，用于为事件添加事件处理程序
            //new EventHandler(RealPlayAndPTZDemo_Load)创建一个EventHandler委托的新实例，负责处理事件，它指定RealPlayAndPTZDemo_Load函数是Load事件的事件处理程序。
        }

        private void RealPlayAndPTZDemo_Load(object sender, EventArgs e)
        {
            m_DisConnectCallBack = new fDisConnectCallBack(DisConnectCallBack);
            m_ReConnectCallBack = new fHaveReConnectCallBack(ReConnectCallBack);
            m_RealDataCallBackEx2 = new fRealDataCallBackEx2(RealDataCallBackEx);
            m_SnapRevCallBack = new fSnapRevCallBack(SnapRevCallBack);
            //该函数首先创建各种委托类型的实例(fDisConnectCallBack, fHaveReConnectCallBack, fRealDataCallBackEx2, fSnapRevCallBack)
            //并将它们分配给相应的变量(m_DisConnectCallBack, m_ReConnectCallBack, m_RealDataCallBackEx2, m_SnapRevCallBack) 必要的初始化

            try  //使用try-catch块处理初始化过程中可能发生的任何异常
            {
                NETClient.Init(m_DisConnectCallBack, IntPtr.Zero, null);        //在try块中，这里NETClient.Init函数被调用，传入m_DisConnectCallBack委托IntPtr.Zero和null作为参数
                                                                                //这个函数负责初始化网络客户端。
                NETClient.SetAutoReconnect(m_ReConnectCallBack, IntPtr.Zero);   //NETClient.SetAutoReconnect函数被调用，传入m_ReConnectCallBack委托和IntPtr.Zero
                                                                                //此函数设置自动重连功能
                NETClient.SetSnapRevCallBack(m_SnapRevCallBack, IntPtr.Zero);   //NETClient.SetAutoReconnect函数被调用，传入m_ReConnectCallBack委托和IntPtr.Zero
                                                                                //此函数设置接收快照的回调函数
                InitOrLogoutUI();     //然后再调用InitOrLogoutUI函数来执行额外的初始化或UI设置
            }
            catch (Exception ex)  //如果在初始化过程中发生异常，则执行catch块
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();  //它显示一个包含异常消息的消息框，并使用process.Getcurrentprocess().kill()终止当前进程
            }
        }
        #region CallBack 回调
        //在“RealPlayAndPTZDemo”类中定义几个回调函数
        private void DisConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        //DisConnectCallBack函数是一个回调函数，当与服务器断开连接时调用
        //它需要几个参数:lLoginID(登录ID)、pchDVRIP(指向DVRIP的指针)、nDVRPort (DVR端口)和dwUser(用户自定义值)。
        {
            this.BeginInvoke((Action)UpdateDisConnectUI);   //在这个函数中，BeginInvoke通过调用UpdateDisConnectUI函数来异步更新UI
        }

        private void UpdateDisConnectUI()
        //UpdateDisConnectUI函数负责在断开连接发生时更新UI
        {
            this.Text = "RealPlayAndPTZDemo(实时预览与云台Demo) --- Offline(离线)";
            //在本例中，它设置表单的Text属性，显示"RealPlayAndPTZDemo(实时预览与云台Demo) --- Offline(离线)"这句话，表明应用程序处于脱机状态
        }

        private void ReConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        //ReConnectCallBack函数是一个回调函数，当与服务器发生重新连接时调用
        //它的参数与DisConnectCallBack函数相似。
        {
            this.BeginInvoke((Action)UpdateReConnectUI);   //与上一个回调类似，它使用BeginInvoke通过调用UpdateReConnectUI函数来异步更新UI
        }
        private void UpdateReConnectUI()   //UpdateReConnectUI函数更新UI，以表明应用程序在成功重连后处于在线状态
        {
            this.Text = "RealPlayAndPTZDemo(实时预览与云台Demo) --- Online(在线)";
        }

        private void RealDataCallBackEx(IntPtr lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr param, IntPtr dwUser)
        //RealDataCallBackEx函数是一个回调函数，在接收到实时数据时调用
        //它接受一些参数，比如lRealHandle(实时数据的句柄)、dwDataType(数据类型)、pBuffer(指向数据缓冲区的指针)、dwBufSize(缓冲区的大小)、param(附加参数)和dwUser(用户定义的值)
        {
            //do something such as save data,send data,change to YUV. 比如保存数据，发送数据，转成YUV等.
        }

        private void SnapRevCallBack(IntPtr lLoginID, IntPtr pBuf, uint RevLen, uint EncodeType, uint CmdSerial, IntPtr dwUser)
        //SnapRevCallBack函数是一个回调函数，在接收到快照时调用
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "capture";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //该方法检查编码类型是否为JPEG(通过EncodeType == 10表示)，然后继续将快照保存到文件中
            if (EncodeType == 10) //.jpg
            {
                DateTime now = DateTime.Now;
                string fileName = "async"+ CmdSerial.ToString()+ ".jpg";
                string filePath = path + "\\" + fileName;
                byte[] data = new byte[RevLen];
                Marshal.Copy(pBuf, data, 0, (int)RevLen);
                using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    stream.Write(data, 0, (int)RevLen);
                    stream.Flush();
                    stream.Dispose();
                }
            }
        }
        #endregion
        //总之，这些回调方法可以处理与连接、重新连接、实时数据和快照相关的各种事件和操作
        //它们允许你更新UI，执行特定任务，或者响应由网络客户端触发的特定事件
        private void port_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_LoginID)
            {
                ushort port = 0;
                try
                {
                    port = Convert.ToUInt16(port_textBox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Input port error(输入端口错误)!");
                    return;
                }
                m_DeviceInfo = new NET_DEVICEINFO_Ex();
                m_LoginID = NETClient.LoginWithHighLevelSecurity(ip_textBox.Text.Trim(), port, name_textBox.Text.Trim(), pwd_textBox.Text.Trim(), EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref m_DeviceInfo);
                if (IntPtr.Zero == m_LoginID)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                LoginUI();
            }
            else
            {
                bool result = NETClient.Logout(m_LoginID);
                if (!result)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                m_LoginID = IntPtr.Zero;
                InitOrLogoutUI();
            }
        }

        private void start_realplay_button_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_RealPlayID)
            {
                // realplay 预览
                EM_RealPlayType type;
                if(streamtype_comboBox.SelectedIndex == 0)
                {
                    type = EM_RealPlayType.Realplay;
                }
                else
                {
                    type = EM_RealPlayType.Realplay_1;
                }
                m_RealPlayID = NETClient.RealPlay(m_LoginID, channel_comboBox.SelectedIndex, realplay_pictureBox.Handle, type);
                if (IntPtr.Zero == m_RealPlayID)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                NETClient.SetRealDataCallBack(m_RealPlayID, m_RealDataCallBackEx2, IntPtr.Zero, EM_REALDATA_FLAG.DATA_WITH_FRAME_INFO | EM_REALDATA_FLAG.PCM_AUDIO_DATA | EM_REALDATA_FLAG.RAW_DATA | EM_REALDATA_FLAG.YUV_DATA);
                start_realplay_button.Text = "StopReal(停止预览)";
                channel_comboBox.Enabled = false;
                streamtype_comboBox.Enabled = false;
                save_button.Enabled = true;
            }
            else
            {
                // stop realplay 关闭预览
                bool ret = NETClient.StopRealPlay(m_RealPlayID);
                if (!ret)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                m_RealPlayID = IntPtr.Zero;
                start_realplay_button.Text = "StartReal(开始预览)";
                realplay_pictureBox.Refresh();
                channel_comboBox.Enabled = true;
                streamtype_comboBox.Enabled = true;
                save_button.Enabled = false;
                if (m_IsInSave)
                {
                    m_IsInSave = false;
                    save_button.Text = "StartSave(开始保存)";
                }
            }
        }

        private void capture_button_Click(object sender, EventArgs e)
        {
            #region remote async snapshot 远程异步抓图
            NET_SNAP_PARAMS asyncSnap = new NET_SNAP_PARAMS();
            asyncSnap.Channel = (uint)channel_comboBox.SelectedIndex;
            asyncSnap.Quality = 6;
            asyncSnap.ImageSize = 2;
            asyncSnap.mode = 0;
            asyncSnap.InterSnap = 0;
            asyncSnap.CmdSerial = m_SnapSerialNum;
            bool ret = NETClient.SnapPictureEx(m_LoginID, asyncSnap, IntPtr.Zero);
            if (!ret)
            {
                MessageBox.Show(this, NETClient.GetLastError());
                return;
            }
            m_SnapSerialNum++;
            #endregion

            #region client capture 本地抓图
            //if (IntPtr.Zero == m_RealPlayID)
            //{
            //    MessageBox.Show(this, "Please realplay first(请先打开预览)!");
            //    return;
            //}
            //string path = AppDomain.CurrentDomain.BaseDirectory + "capture";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //string filePath = path + "\\" + "client" + m_SnapSerialNum.ToString() + ".jpg";
            //bool result = NETClient.CapturePicture(m_RealPlayID, filePath, EM_NET_CAPTURE_FORMATS.JPEG);
            //if (!result)
            //{
            //    MessageBox.Show(this, NETClient.GetLastError());
            //    return;
            //}
            //MessageBox.Show(this, "client capture success(本地抓图成功)!");
            #endregion
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_RealPlayID)
            {
                MessageBox.Show(this, "Please realplay first(请先打开预览)!");
                return;
            }
            if (m_IsInSave)
            {
                bool ret = NETClient.StopSaveRealData(m_RealPlayID);
                if (!ret)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                m_IsInSave = false;
                save_button.Text = "StartSave(开始保存)";
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "data";
                saveFileDialog.Filter = "|*.dav";
                string path = AppDomain.CurrentDomain.BaseDirectory + "savedata";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                saveFileDialog.InitialDirectory = path;
                var res = saveFileDialog.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    m_IsInSave = NETClient.SaveRealData(m_RealPlayID, saveFileDialog.FileName); //call saverealdata function.
                    if (!m_IsInSave)
                    {
                        saveFileDialog.Dispose();
                        MessageBox.Show(this, NETClient.GetLastError());
                        return;
                    }
                    save_button.Text = "StopSave(停止保存)";
                }
                saveFileDialog.Dispose();
            }
        }

        #region PTZ Control 云台控制

        private void step_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeedValue = step_comboBox.SelectedIndex + 1;
        }

        private void PTZControl(EM_EXTPTZ_ControlType type, int param1, int param2, bool isStop)
        {
            bool ret = NETClient.PTZControl(m_LoginID, channel_comboBox.SelectedIndex, type, param1, param2, 0, isStop, IntPtr.Zero);
            if (!ret)
            {
                MessageBox.Show(this, NETClient.GetLastError());
            }
        }

        private void topleft_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFTTOP, SpeedValue, SpeedValue, false);
        }

        private void topleft_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFTTOP, SpeedValue, SpeedValue, true);
        }

        private void top_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.UP_CONTROL, 0, SpeedValue, false);
        }

        private void top_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.UP_CONTROL, 0, SpeedValue, true);
        }

        private void topright_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHTTOP, SpeedValue, SpeedValue, false);
        }

        private void topright_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHTTOP, SpeedValue, SpeedValue, true);
        }

        private void left_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFT_CONTROL, 0, SpeedValue, false);
        }

        private void left_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFT_CONTROL, 0, SpeedValue, true);
        }

        private void right_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHT_CONTROL, 0, SpeedValue, false);
        }

        private void right_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHT_CONTROL, 0, SpeedValue, true);
        }

        private void bottomleft_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFTDOWN, SpeedValue, SpeedValue, false);
        }

        private void bottomleft_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.LEFTDOWN, SpeedValue, SpeedValue, true);
        }

        private void bottom_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.DOWN_CONTROL, 0, SpeedValue, false);
        }

        private void bottom_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.DOWN_CONTROL, 0, SpeedValue, true);
        }

        private void bottomright_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHTDOWN, SpeedValue, SpeedValue, false);
        }

        private void bottomright_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.RIGHTDOWN, SpeedValue, SpeedValue, true);
        }

        private void zoomadd_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.ZOOM_ADD_CONTROL, 0, SpeedValue, false);
        }

        private void zoomadd_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.ZOOM_ADD_CONTROL, 0, SpeedValue, true);
        }

        private void zoomdec_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.ZOOM_DEC_CONTROL, 0, SpeedValue, false);
        }

        private void zoomdec_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.ZOOM_DEC_CONTROL, 0, SpeedValue, true);
        }

        private void focusadd_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.FOCUS_ADD_CONTROL, 0, SpeedValue, false);
        }

        private void focusadd_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.FOCUS_ADD_CONTROL, 0, SpeedValue, true);
        }

        private void focusdec_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.FOCUS_DEC_CONTROL, 0, SpeedValue, false);
        }

        private void focusdec_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.FOCUS_DEC_CONTROL, 0, SpeedValue, true);
        }

        private void apertureadd_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.APERTURE_ADD_CONTROL, 0, SpeedValue, false);
        }

        private void apertureadd_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.APERTURE_ADD_CONTROL, 0, SpeedValue, true);
        }

        private void aperturedec_button_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.APERTURE_DEC_CONTROL, 0, SpeedValue, false);
        }

        private void aperturedec_button_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(EM_EXTPTZ_ControlType.APERTURE_DEC_CONTROL, 0, SpeedValue, true);
        }
        #endregion

        #region Update UI 更新UI
        private void InitOrLogoutUI()
        {
            step_comboBox.Enabled = false;
            step_comboBox.Items.Clear();
            login_button.Text = "Login(登录)";
            channel_comboBox.Items.Clear();
            channel_comboBox.Enabled = false;
            streamtype_comboBox.Items.Clear();
            streamtype_comboBox.Enabled = false;
            start_realplay_button.Enabled = false;
            capture_button.Enabled = false;
            save_button.Enabled = false;
            topleft_button.Enabled = false;
            topright_button.Enabled = false;
            top_button.Enabled = false;
            left_button.Enabled = false;
            right_button.Enabled = false;
            bottom_button.Enabled = false;
            bottomleft_button.Enabled = false;
            bottomright_button.Enabled = false;
            zoomadd_button.Enabled = false;
            zoomdec_button.Enabled = false;
            focusadd_button.Enabled = false;
            focusdec_button.Enabled = false;
            apertureadd_button.Enabled = false;
            aperturedec_button.Enabled = false;
            m_RealPlayID = IntPtr.Zero;
            start_realplay_button.Text = "StartReal(开始预览)";
            realplay_pictureBox.Refresh();
            save_button.Text = "StartSave(开始保存)";
            this.Text = "RealPlayAndPTZDemo(实时预览与云台Demo)";
        }
        private void LoginUI()
        {
            step_comboBox.Enabled = true;
            for (int i = MinSpeed; i <= MaxSpeed; i++)
            {
                step_comboBox.Items.Add(i);
            }
            step_comboBox.SelectedIndex = SpeedValue - 1;
            login_button.Text = "Logout(登出)";
            channel_comboBox.Enabled = true;
            streamtype_comboBox.Enabled = true;
            start_realplay_button.Enabled = true;
            capture_button.Enabled = true;
            topleft_button.Enabled = true;
            topright_button.Enabled = true;
            top_button.Enabled = true;
            left_button.Enabled = true;
            right_button.Enabled = true;
            bottom_button.Enabled = true;
            bottomleft_button.Enabled = true;
            bottomright_button.Enabled = true;
            zoomadd_button.Enabled = true;
            zoomdec_button.Enabled = true;
            focusadd_button.Enabled = true;
            focusdec_button.Enabled = true;
            apertureadd_button.Enabled = true;
            aperturedec_button.Enabled = true;
            for (int i = 1; i <= m_DeviceInfo.nChanNum; i++)
            {
                channel_comboBox.Items.Add(i);
            }
            streamtype_comboBox.Items.Add("Main Stream(主码流)");
            streamtype_comboBox.Items.Add("Extra Stream(辅码流)");
            channel_comboBox.SelectedIndex = 0;
            streamtype_comboBox.SelectedIndex = 0;
            this.Text = "RealPlayAndPTZDemo(实时预览与云台Demo) --- Online(在线)";
        }
        #endregion

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            NETClient.Cleanup();
        }
    }
}
