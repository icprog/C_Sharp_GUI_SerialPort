using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestPID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _PV = new double[Canvas.Width];
            _MV = new double[Canvas.Width];

            KP.Value = 1;
            SP.Value = 75;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Green, 0, (int)SP.Value, _PV.Length, (int)SP.Value);

            int last_x = 0;
            int last_pv = 0;
            int last_mv = 0;

            for (int i = 0; i < _PV.Length; i++)
            {
                if (i > 0)
                {
                    e.Graphics.DrawLine(Pens.Red, last_x, last_pv, i, (int)_PV[i]);

                    if (ShowMV.Checked)
                        e.Graphics.DrawLine(Pens.White, last_x, last_mv, i, (int)_MV[i]);
                }

                last_x = i;
                last_pv = (int)_PV[i];
                last_mv = (int)_MV[i];
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            _Error = 0;        // 偏差
            _ErrorError = 0;   // 上次偏差
            _ErrorSum = 0; // 积分
            _ErrorDev = 0;// 微分

            _Last_PV = 0;
            _Last_MV = 0;

            for (int i = 0; i < _PV.Length; i++)
            {
                PID();
                //_Last_MV = 50;
                Actor();

                _PV[i] = _Last_PV;
                _MV[i] = _Last_MV;
            }

            Canvas.Invalidate();
        }

        ///////////////////////////////////////////////////////
        // PID 控制器状态
        double _Error = 0;        // 偏差
        double _ErrorError = 0;   // 上次偏差
        double _ErrorSum = 0; // 积分
        double _ErrorDev = 0;// 微分

        double[] _PV;
        double[] _MV;

        double _Last_PV = 0;
        double _Last_MV = 0;

        public void PID()
        {
            _Error = (double)SP.Value - _Last_PV; // 偏差
            _ErrorSum += _Error; // 积分
            _ErrorDev = _Error - _ErrorError;
            _ErrorError = _Error;

            _Last_MV = 
                (double)KP.Value * _Error + 
                (double)KI.Value * _ErrorSum + 
                (double)KD.Value * _ErrorDev;

            if (_Last_MV > 150)
                _Last_MV = 150;

            if (_Last_MV < 5)
                _Last_MV = 5;
        }

        // 滞后模拟
        public void Actor()
        {
            _Last_PV += (_Last_MV - _Last_PV) / 30;
        }

        private void SP_ValueChanged(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }
    }
}
