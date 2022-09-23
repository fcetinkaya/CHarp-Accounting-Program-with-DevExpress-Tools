using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace Gelisim_Muhasebe
{
    public partial class frmWait : WaitForm
    {
        public frmWait()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        //Wait form üzerindeki Please Wait yazısını değiştirmek için kullanılır.
        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        //Wait form üzerindeki Loading.. yazısını değiştirmek için kullanılır.
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        //Forma gelen komutların işlendiği metoddur. Detayları ileride anlatılacaktır.
        public override void ProcessCommand(Enum cmd, object arg)
        {
            switch ((WaitFormCommand) cmd)
            {
                case WaitFormCommand.SetProgressBarVisible:
                    //Gelen komut eğer SetProgressBarVisible komutu ise, arg bir boolean değer olmalıdır. Bu değeri biz progressbarımızın Visible özelliğine aktarıyoruz.
                    progressBarControl1.Visible = (bool) arg;
                    break;
                    
                case WaitFormCommand.SetProgressBarMaximum:
                    //Gelen komut eğer SetProgressBarMaximum komutu ise, arg bir integer değer olmalıdır. Bu değeri biz progressbarımızın Properties.Maximum özelliğine aktarıyoruz.
                    progressBarControl1.Properties.Maximum = (int) arg;
                    break;
                    
                case WaitFormCommand.SetProgressBarPosition:
                    //Gelen komut eğer SetProgressBarPosition komutu ise, arg bir integer değer olmalıdır. Bu değeri biz progressbarımızın Position özelliğine aktarıyoruz.
                    progressBarControl1.Position = (int) arg;
                    break;
            }
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        //public void BeklemeEkraniGoster()
        //{
        //    SplashScreenManager.ShowForm(typeof(frmWait));
        //SplashScreenManager.Default.SendCommand(frmWait.WaitFormCommand.SetProgressBarVisible, true);
        //SplashScreenManager.Default.SendCommand(frmWait.WaitFormCommand.SetProgressBarMaximum, gridView1.RowCount);

        //    CariArama();
        //    for (int i = 0; i < gridView1.RowCount; i++)
        //    {
        //    SplashScreenManager.Default.SetWaitFormDescription(string.Format("Yapılan işlem: {0}/{1}", i + 1,
        //    gridView1.RowCount));
        //    SplashScreenManager.Default.SendCommand(frmWait.WaitFormCommand.SetProgressBarPosition, i);

        //    System.Threading.Thread.Sleep(1500);
        //    }

        //    SplashScreenManager.CloseForm();
        //}
        public enum WaitFormCommand
        {
            SetProgressBarVisible,
            SetProgressBarMaximum,
            SetProgressBarPosition
        }
    }
}