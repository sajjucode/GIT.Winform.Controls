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

namespace GIT.Winform.Controls
{
    public partial class gitTextBox : TextBox
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

        [Description("Use to set Control use user specified design?"), Category("GITProperties"), DefaultValue("False")]
        public Boolean isUseCurrentStyle { get; set; }
        #endregion

        #region "Keys etc"
        [Description("Use to set Control to be focused on Enter key."), Category("GITProperties")]
        public Control OnEnterNextControl { get; set; }
        #endregion

        #region "Misc"
        public enum DataType { Text, Number, Decimal, NoSpace };

        [Description("Use to set Control Data Type."), Category("GITProperties")]
        public DataType InputDataType { get; set; }

        private Boolean _isNonEditable = false;
        [Description("Use to set Control Readonly with our apperance properties."), Category("GITProperties"), DefaultValue("False")]
        public Boolean NonEditable
        {
            get
            {
                return _isNonEditable;
            }
            set
            {
                if (value == true)
                {
                    this.isRequired = false;
                }
                _isNonEditable = value;
            }
        }

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
                if (value == true)
                {
                    this.NonEditable = false;
                }

                _isRequired = value;
            }
        }

        private Boolean _AllowNumberIncrement = false;
        private Double Increment = 1;
        [Description("Use to set Control Auto Number Increment on Mouse double Click?"), Category("GITProperties"), DefaultValue("False")]
        public Boolean AllowNumberIncremenent
        {
            get
            {
                return _AllowNumberIncrement;
            }
            set
            {
                _AllowNumberIncrement = value;
            }
        }

        [Description("Use to set Number Increment Step?"), Category("GITProperties"), DefaultValue("False")]
        public Double IncrementStep
        {
            get
            {
                return Increment;
            }
            set
            {
                Increment = value;
            }
        }


        Decimal? _MinimumValue;
        Decimal? _MaximumValue;

        [Description("Use to Set Minimum Value"), Category("GITProperties"), DefaultValue(0)]
        public Decimal? MinimumValue
        {
            get
            {
                return _MinimumValue;
            }
            set
            {
                _MinimumValue = value;
            }
        }

        [Description("Use to Set Maximun Value"), Category("GITProperties"), DefaultValue(0)]
        public Decimal? MaximumValue
        {
            get
            {
                return _MaximumValue;
            }
            set
            {
                _MaximumValue = value;
            }
        }
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

        public gitTextBox()
        {
            InitializeComponent();
            //this.OnMouseWheel += new System.EventHandler (this.)
        }

        #region "Events"
        private void gitTextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.ForeColor = this.onFocusColor;
                    this.BackColor = this.onFocusBackGround;
                    this.Font = this.onFocusFont;
                }
                else
                {
                    this.ForeColor = Stylings.onFocusColor;
                    this.BackColor = Stylings.onFocusBackGround;
                    this.Font = Stylings.onFocusFont;
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void gitTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.ForeColor = this.onLostColor;
                    this.BackColor = this.onLostBackGround;
                    this.Font = this.onLostFont;
                }
                else
                {
                    this.ForeColor = Stylings.onLostColor;
                    this.BackColor = Stylings.onLostBackGround;
                    this.Font = Stylings.onLostFont;
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void gitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                char ch = e.KeyChar;

                if (this.NonEditable == true)
                {
                    e.Handled = true;
                    this.myErrorProvider.SetError(this, Validations.ReadOnly);
                }
                else if (this.InputDataType == DataType.Number)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        this.myErrorProvider.SetError(this, Validations.Numeric);
                        this.myErrorProvider.ContainerControl.Focus();
                    }
                    else
                    {
                        this.myErrorProvider.Clear();
                    }
                }
                else if (this.InputDataType == DataType.Decimal)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                        this.myErrorProvider.SetError(this, Validations.Decimal);
                        this.myErrorProvider.ContainerControl.Focus();
                    }
                    else
                    {
                        this.myErrorProvider.Clear();
                    }
                }
                else if (this.InputDataType == DataType.NoSpace && e.KeyChar != (char)Keys.Enter)
                {
                    if (char.IsWhiteSpace(e.KeyChar) == true)
                    {
                        e.Handled = true;
                        this.myErrorProvider.SetError(this, Validations.NoSpace);
                        this.myErrorProvider.ContainerControl.Focus();
                    }
                    else
                    {
                        this.myErrorProvider.Clear();
                    }
                }

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
        #endregion

        private void gitTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.isRequired == true && String.IsNullOrEmpty(this.Text) == true)
                {
                    e.Cancel = true;
                    this.myErrorProvider.SetError(this, Validations.Required);
                    this.Focus();
                }

                if ((this.InputDataType == DataType.Decimal || this.InputDataType == DataType.Number) && (this._MinimumValue.HasValue == true || this._MaximumValue.HasValue == true))
                {
                    if (string.IsNullOrEmpty(this.Text) == false)
                    {
                        if (_MaximumValue.HasValue == true && _MinimumValue.HasValue == true)
                        {
                            if (Conversions.ConvertToDecimal(this.Text) < _MinimumValue.Value || Conversions.ConvertToDecimal(this.Text) > _MaximumValue.Value)
                            {
                                e.Cancel = true;
                                this.myErrorProvider.SetError(this, Validations.ValueLimitation(_MinimumValue.Value.ToString(), _MaximumValue.Value.ToString()));
                                this.Focus();
                            }
                        }
                        else if (_MaximumValue.HasValue == true && Conversions.ConvertToDecimal(this.Text) < _MinimumValue.Value)
                        {
                            e.Cancel = true;
                            this.myErrorProvider.SetError(this, Validations.MinimumValueError(_MinimumValue.Value.ToString()));
                            this.Focus();
                        }
                        else if (_MaximumValue.HasValue == true && Conversions.ConvertToDecimal(this.Text) > _MaximumValue.Value)
                        {
                            e.Cancel = true;
                            this.myErrorProvider.SetError(this, Validations.MaximumValueError(_MaximumValue.Value.ToString()));
                            this.Focus();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validating " + this.Name);

            }
        }

        private void gitTextBox_Validated(object sender, EventArgs e)
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

        private void gitTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this._AllowNumberIncrement == true)
                {
                    if (this.InputDataType == DataType.Number)
                    {
                        this.SelectAll();
                        this.Text = (Conversions.ConvertToInt64(this.Text) + Increment).ToString();
                    }
                    else if (this.InputDataType == DataType.Decimal)
                    {
                        this.SelectAll();
                        this.Text = (Conversions.ConvertToDecimal(this.Text) + Conversions.ConvertToDecimal(Increment.ToString())).ToString();
                    }
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void gitTextBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if (this._AllowNumberIncrement == true)
                {
                    if (this.InputDataType == DataType.Number)
                    {
                        this.SelectAll();
                        this.Text = (Conversions.ConvertToInt64(this.Text) + Increment).ToString();
                    }
                    else if (this.InputDataType == DataType.Decimal)
                    {
                        this.SelectAll();
                        this.Text = (Conversions.ConvertToDecimal(this.Text) + Conversions.ConvertToDecimal(Increment.ToString())).ToString();
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}
