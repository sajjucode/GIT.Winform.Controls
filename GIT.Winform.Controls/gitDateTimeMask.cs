using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIT.Winform.Controls.CommonSettings;
using System.Globalization;

namespace GIT.Winform.Controls
{
    public partial class gitDateTimeMask : UserControl
    {
        #region "Appearances"
        [Description("Use to set Forecolor when control focused or active."), Category("GITProperties")]
        public Color onFocusColor { get; set; }

        [Description("Use to set Font style when control focused or active."), Category("GITProperties")]
        public Font onFocusFont { get; set; }

        [Description("Use to set Background when control focused or active."), Category("GITProperties")]
        public Color onFocusBackGround { get; set; }

        [Description("Use to set Forecolor when control focused left."), Category("GITProperties")]
        public Color onLostColor { get; set; }
        [Description("Use to set Background when control focused left."), Category("GITProperties")]
        public Color onLostBackGround { get; set; }

        [Description("Use to set Font when control focused left."), Category("GITProperties")]
        public Font onLostFont { get; set; }
        #endregion
        #region "Keys etc"
        [Description("Use to set Control to be focused on Enter key."), Category("GITProperties")]
        public Control OnEnterNextControl { get; set; }
        #endregion
        #region "Validation Error"
        private ErrorProvider _myErrorProvider = new ErrorProvider();

        [Description("Use to set Error provider."), Category("MyProperties")]
        public ErrorProvider myErrorProvider
        {
            get
            {
                return _myErrorProvider;
            }
            set
            {
                _myErrorProvider = value;
            }
        }
        #endregion

        #region "Date Formats"
        public enum _DateTimeFormat {FullDateTime,FullDate,Date,Time24,Time12,Customer };
        private _DateTimeFormat CurrentDateTimeFormatType;
        private string CurrentDateTimeFormat = "MM/dd/yyyy HH:mm:ss";
        private string MaskFormat = "MM/dd/yyyy HH:mm:ss";       

        [Description("Use to set Customer DateTime Format."), Category("GITProperties"), DefaultValue("False")]
        public string CustomerDateTimeFormat
        {
            get
            {
                return CurrentDateTimeFormat;
            }
            set
            {
                if (value !=null)
                {
                    MaskFormat = string.Empty;
                    foreach (char myC in value)
                    {
                        if (myC.ToString() == "/" || myC.ToString() == ":" || myC.ToString() == " ")
                        {
                            MaskFormat = MaskFormat + myC.ToString();
                        }
                        else
                        {
                            MaskFormat = MaskFormat + "#";
                            
                        }
                    }
                }
                this.InputDateTimemaskedTextBox.Mask = MaskFormat ;
                this.lblDateTimeFormat.Text = value;
                CurrentDateTimeFormat = value;
                this.IcondateTimePicker.Format = DateTimePickerFormat.Custom;
                this.IcondateTimePicker.CustomFormat = value;

            }
        }

        [Description("Use to set DateTime Format."), Category("GITProperties"), DefaultValue("False")]
        public _DateTimeFormat DateTimeFormat
        {
            get
            {
                return CurrentDateTimeFormatType;
            }
            set
            {
                CurrentDateTimeFormatType = value;
                switch (value)
                {
                    case _DateTimeFormat.FullDateTime :
                        this.CustomerDateTimeFormat = "ddd MM/dd/yyyy HH:mm:ss";
                        break;
                    case _DateTimeFormat.FullDate:
                        this.CustomerDateTimeFormat = "ddd MM/dd/yyyy";
                        break;
                    case _DateTimeFormat.Date:
                        this.CustomerDateTimeFormat = "MM/dd/yyyy";
                        break;
                    case _DateTimeFormat.Time24:
                        this.CustomerDateTimeFormat = "HH:mm:ss";
                        break;
                    case _DateTimeFormat.Time12:
                        this.CustomerDateTimeFormat = "hh:mm:ss tt";
                        break;
                    case _DateTimeFormat.Customer:
                        this.CustomerDateTimeFormat = "ddd MM/dd/yyyy HH:mm:ss";
                        break;
                }
            }
        }

        private Boolean _UseCommonDateFormat = false;
        [Description("Use to set forcally use Common DateTime Format."), Category("GITProperties"), DefaultValue("False")]
        public Boolean UseCommonDateFormat
        {
           get
            {
                return _UseCommonDateFormat;
            }
            set
            {
                if (value ==true )
                {
                    this.CustomerDateTimeFormat = Stylings.InputDateTimeFormat;
                }

                _UseCommonDateFormat = value;
            }
        }


        #endregion

        #region "Return Values"
        private DateTime _returnValue = DateTime.Now;
        [Description("Use to get or set Value."), Category("GITProperties"),Bindable(true) ]
        public DateTime value
        {
            get
            {
                _returnValue = Conversions.StringToDateTime(this.InputDateTimemaskedTextBox.Text, this.CurrentDateTimeFormat); 
                return _returnValue;
            }
            set
            {
                //if (value.Year <1800)
                //{
                //    value = DateTime.Now;
                //}

                this.InputDateTimemaskedTextBox.Text = value.ToString(this.CurrentDateTimeFormat);
                this.IcondateTimePicker.Value = value.Year < 1800 ? DateTime.Now : value;
                _returnValue = value;
            }
        }
        #endregion

        #region "Mics"
        [Description("Use to set Control use user specified design?"), Category("GITProperties"), DefaultValue("False")]
        public Boolean isUseCurrentStyle { get; set; }

        private Boolean _isRequired = false;
        [Description("Use to set Control isRequired?"), Category("GITProperties"), DefaultValue("False")]
        public Boolean isRequired
        {
            get
            {
                return _isRequired;
            }
            set
            {
                _isRequired = value;
            }
        }
        #endregion

        public gitDateTimeMask()
        {
            InitializeComponent();
        }

        private void gitDateTimeMask_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblDateTimeFormat.Font = new Font(new FontFamily("Calibri"), 8);
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void IcondateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.InputDateTimemaskedTextBox.Text = this.IcondateTimePicker.Value.ToString(this.CurrentDateTimeFormat);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void InputDateTimemaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                char ch = e.KeyChar;              

                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (this.OnEnterNextControl != null)
                    {
                        this.myErrorProvider.Clear();
                        this.OnEnterNextControl.Focus();
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void InputDateTimemaskedTextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.InputDateTimemaskedTextBox.ForeColor = this.onFocusColor;
                    this.InputDateTimemaskedTextBox.BackColor = this.onFocusBackGround;
                    this.InputDateTimemaskedTextBox.Font = this.onFocusFont;
                }
                else
                {
                    this.InputDateTimemaskedTextBox.ForeColor = Stylings.onFocusColor;
                    this.InputDateTimemaskedTextBox.BackColor = Stylings.onFocusBackGround;
                    this.InputDateTimemaskedTextBox.Font = Stylings.onFocusFont;
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void InputDateTimemaskedTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.InputDateTimemaskedTextBox.ForeColor = this.onLostColor;
                    this.InputDateTimemaskedTextBox.BackColor = this.onLostBackGround;
                    this.InputDateTimemaskedTextBox.Font = this.onLostFont;
                }
                else
                {
                    this.InputDateTimemaskedTextBox.ForeColor = Stylings.onLostColor;
                    this.InputDateTimemaskedTextBox.BackColor = Stylings.onLostBackGround;
                    this.InputDateTimemaskedTextBox.Font = Stylings.onLostFont;
                }                
            }
            catch (Exception ex)
            {


            }
        }

        private void InputDateTimemaskedTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                this.myErrorProvider.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Validated " + this.Name);
            }
        }

        private void InputDateTimemaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.isRequired == true )
                {
                    DateTime myValue;

                    if (DateTime.TryParseExact(this.InputDateTimemaskedTextBox.Text, this.CurrentDateTimeFormat, Conversions.myCulture, DateTimeStyles.None, out myValue)==false)
                    {
                        if (myValue.Year < 1900)
                        {
                            e.Cancel = true;
                            this.myErrorProvider.SetError(this, Validations.Required);
                            this.Focus();
                        }
                        else
                        {
                            this.value = myValue;
                        }

                        
                    }
                    else
                    {
                        
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validating " + this.Name);

            }
        }
    }
}
