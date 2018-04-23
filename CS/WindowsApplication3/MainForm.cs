using System;
using DevExpress.XtraEditors;
using System.Drawing;


namespace WindowsApplication3 {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0; i < 5; i++) {
                dataSet11.Tables[0].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i, DateTime.Today.AddDays(i), true });
                dataSet11.Tables[1].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i });
            }
        }
        void Form1_Load(object sender, EventArgs e) {
            InitData();
        }
    }
}