using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

public class NumBox : TextBox
{
    public NumBox() :  base()
    {
        AutoSize = false;
        
    }
    [Bindable(true), Category("Setting"),
    DefaultValue(false), Description("덪 붙임 문자를 사용합니다.")]
    public bool UseFormatString { get; set; } = false;
    public override bool AutoSize
    {
        get { return base.AutoSize; }
        set { base.AutoSize = false; }
    }
    [Bindable(true), Category("Setting"),
    DefaultValue(""), Description("덪 붙일 문자를 지정합니다.")]
    public string FormatString { get; set; } = "";
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (!UseFormatString) return;
        if (!Focused)
        {
            e.Graphics.Clear(BackColor);
            using (SolidBrush sb = new SolidBrush(this.ForeColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString($"{Text} {FormatString}", this.Font, sb, ClientRectangle, sf);
            }
        }
    }
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        NumberFormatInfo numberFormatInfo = CultureInfo.CurrentCulture.NumberFormat; //국가별 숫자 형식 가져오기

        string keyInput = e.KeyChar.ToString();

        if (char.IsDigit(e.KeyChar))
        { // 숫자 키
        }
        else if (keyInput.Equals(numberFormatInfo.NumberDecimalSeparator))
        { // 소수점 구분자
        }
        else if (keyInput.Equals(numberFormatInfo.NumberGroupSeparator))
        { // 괄호
        }
        else if (keyInput.Equals(numberFormatInfo.NegativeSign))
        { // 마이너스 키
        }
        else if (e.KeyChar == '\b')
        { //백스페이스 키
        }
        else if (e.KeyChar == (char)Keys.Enter)
        {
            SendKeys.Send("{TAB}");
        }
        else
        { // 나머지 불용
            e.Handled = true;
        }
       
    }
    protected override void OnTextChanged(EventArgs e)
    {
        double value = 0;
        double.TryParse(Text, out value);
        if (Min > value) Text = Min.ToString();
        if (Max < value) Text = Max.ToString();
        base.OnTextChanged(e);
    }
    const int WM_PAINT = 0x000F;
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        switch (m.Msg)
        {
            case WM_PAINT:
                OnPaint(new PaintEventArgs(Graphics.FromHwnd(Handle), ClientRectangle));
                break;
        }
    }
   [Bindable(true), Category("Setting"),
    DefaultValue(100), Description("입력 가능 최대치를 입력 합니다.")]
    public double Max
    {
        get;
        set;
    } = 100;
    [Bindable(true), Category("Setting"),
    DefaultValue(1), Description("입력 가능 최소치를 입력 합니다.")]
    public double Min
    {
        get;
        set;
    } = 1;

    public int Number
    {
        get
        {
            int result;
            int.TryParse(this.Text, out result);
            return result;
        }
        set
        {
            Text = value.ToString();
        }
    }
    public decimal Decimal
    {
        get
        {
            decimal result;
            decimal.TryParse(this.Text, out result);
            return result;
        }
        set
        {
            Text = value.ToString();
        }
    }

    public double Double
    {
        get
        {
            double result;
            double.TryParse(this.Text, out result);
            return result;
        }
        set
        {
            Text = value.ToString();
        }
    }
    


}

