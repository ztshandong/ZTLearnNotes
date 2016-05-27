using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using DevExpress.XtraSplashScreen;

namespace Library.Forms
{
    public partial class ZTWaitForm : WaitForm
    {
      
        public ZTWaitForm()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
             }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }

    public class frmWaiting
    {
        public static void ShowMe(Form frm, string message= "请稍候...", string caption= "正在处理")
        {
            SplashScreenManager.ShowForm(frm, typeof(ZTWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription(message);
            SplashScreenManager.Default.SetWaitFormCaption(caption);
        }


        //public static void ShowMe(Form frm)
        //{
        //    SplashScreenManager.ShowForm(frm, typeof(ZTWaitForm), true, true, false);
        //}

        public static void HideMe(Form frm)
        {
            SplashScreenManager.CloseForm(false);
            //SplashScreenManager.CloseDefaultSplashScreen();
            //SplashScreenManager.CloseDefaultWaitForm();            
        }
    }
}