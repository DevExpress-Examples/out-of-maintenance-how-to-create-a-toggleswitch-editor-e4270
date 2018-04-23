using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsApplication3 {
    public class ToggleSwitchViewInfo : CheckEditViewInfo {
        public ToggleSwitchViewInfo(RepositoryItem item)
            : base(item) {
        }
      
        protected override void UpdateCheckProperties(DevExpress.Utils.Drawing.BaseCheckObjectInfoArgs e)
        {
            base.UpdateCheckProperties(e);
            CheckObjectInfoArgs args = e as CheckObjectInfoArgs;
            if (args.CheckState == System.Windows.Forms.CheckState.Checked)
                e.Caption = Item.OnText;
            else
                e.Caption = Item.OffText;
        }

        new RepositoryItemToggleSwitch Item {
            get { return base.Item as RepositoryItemToggleSwitch; }
        }
        public override bool IsSupportFastViewInfo {
            get { return false; }
        }
    }
}
