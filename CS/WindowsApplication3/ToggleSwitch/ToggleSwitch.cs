using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication3 {
    public class ToggleSwitch : CheckEdit {
        static ToggleSwitch() { RepositoryItemToggleSwitch.RegisterCustomEdit(); }

        #region HidePropertiesEvents
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new virtual bool Checked {
            get { return base.Checked; }
            set { }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new virtual CheckState CheckState {
            get { return base.CheckState; }
            set { }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event EventHandler CheckedChanged;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event EventHandler CheckStateChanged;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event QueryCheckStateByValueEventHandler QueryCheckStateByValue;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event QueryValueByCheckStateEventHandler QueryValueByCheckState;
        #endregion

        #region NewPropertiesEvents
        public event EventHandler Toggled {
            add { Properties.Toggled += value; }
            remove { Properties.Toggled -= value; }
        }
        [Browsable(false)]
        public bool IsOn {
            get { return base.Checked; }
            set {
                if(base.Checked != value)
                    base.Checked = value;
            }
        }
        protected override void OnEditValueChanged() {
            base.OnEditValueChanged();
            Properties.RaiseToggled(EventArgs.Empty);
        }
        #endregion

        public override string EditorTypeName {
            get { return RepositoryItemToggleSwitch.ToggleSwitchName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemToggleSwitch Properties {
            get { return base.Properties as RepositoryItemToggleSwitch; }
        }
    }
}