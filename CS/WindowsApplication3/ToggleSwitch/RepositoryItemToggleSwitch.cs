using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication3 {
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemToggleSwitch : RepositoryItemCheckEdit {
        static RepositoryItemToggleSwitch() { RegisterCustomEdit(); }
        public RepositoryItemToggleSwitch() {
            base.CheckStyle = CheckStyles.UserDefined;
            base.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            base.PictureUnchecked = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchOff.png", typeof(RepositoryItemToggleSwitch).Assembly);
            base.PictureChecked = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchOn.png", typeof(RepositoryItemToggleSwitch).Assembly);
            base.PictureGrayed = ResourceImageHelper.CreateImageFromResources("WindowsApplication3.Resources.ToggleSwitchDisabled.png", typeof(RepositoryItemToggleSwitch).Assembly);
        }
        public const string ToggleSwitchName = "ToggleSwitch";
        public override string EditorTypeName { get { return ToggleSwitchName; } }

        #region HidePropertiesEvents
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DevExpress.Utils.HorzAlignment GlyphAlignment { get { return DevExpress.Utils.HorzAlignment.Far; } set { } }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new CheckStyles CheckStyle { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string DisplayValueChecked { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string DisplayValueGrayed { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string DisplayValueUnchecked { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ImageIndexChecked { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ImageIndexGrayed { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ImageIndexUnchecked { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image PictureChecked { get { return base.PictureChecked; } set { } }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image PictureGrayed { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image PictureUnchecked { get { return base.PictureUnchecked; } set { } }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int RadioGroupIndex { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object ValueChecked { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object ValueGrayed { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object ValueUnchecked { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event EventHandler CheckedChanged;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event EventHandler CheckStateChanged;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event QueryCheckStateByValueEventHandler QueryCheckStateByValue;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new event QueryValueByCheckStateEventHandler QueryValueByCheckState;
        #endregion

        #region NewProperties
        string _OnContent = "On";
        string _OffContent = "Off";
        [DefaultValue("Off")]
        public string OffText {
            get { return _OffContent; }
            set {
                if(OffText == value) return;
                _OffContent = value;
                OnPropertiesChanged();
            }
        }
        [DefaultValue("On")]
        public string OnText {
            get { return _OnContent; }
            set {
                if(OnText == value) return;
                _OnContent = value;
                OnPropertiesChanged();
            }
        }
        Image _onImage;
        [DefaultValue(null)]
        public Image OnImage
        {
            get { return _onImage; }
            set
            {
                if (OnImage == value) return;
                _onImage = value;
                base.PictureChecked = value;
                OnPropertiesChanged();
            }
        }
        Image _offImage;
        [DefaultValue(null)]
        public Image OffImage
        {
            get { return _offImage; }
            set
            {
                if (OffImage == value) return;
                _offImage = value;
                base.PictureUnchecked = value;
                OnPropertiesChanged();
            }
        }

        #endregion

        #region NewEvent

        static readonly object _toggled = new object();

        public event EventHandler Toggled {
            add { Events.AddHandler(_toggled, value); }
            remove { Events.RemoveHandler(_toggled, value); }
        }


        protected internal virtual void RaiseToggled(EventArgs e) {
            EventHandler handler = Events[_toggled] as EventHandler;
            if(handler != null)
                handler(GetEventSender(), e);
        }
        #endregion
        public static void RegisterCustomEdit() {
            Image img = null;
            try {
                img = (Bitmap)Bitmap.FromStream(typeof(RepositoryItemToggleSwitch).Assembly.
                  GetManifestResourceStream("WindowsApplication3.Resources.ToggleSwitchOn.png"));
            }
            catch { }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(ToggleSwitchName,
              typeof(ToggleSwitch), typeof(RepositoryItemToggleSwitch),
              typeof(ToggleSwitchViewInfo), new CheckEditPainter(), true, img));
        }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemToggleSwitch source = item as RepositoryItemToggleSwitch;
                if(source == null) return;
                OnText = source.OnText;
                OffText = source.OffText;
                OnImage = source.OnImage;
                OffImage = source.OffImage;
                Events.AddHandler(_toggled, source.Events[_toggled]);
            }
            finally {
                EndUpdate();
            }
        }
    }
}