using System.Drawing;
using System.Windows.Forms;

internal class GCheckBox : CheckBox
{
    public GCheckBox()
    {
        TextAlign = ContentAlignment.MiddleRight;
    }

    public override bool AutoSize
    {
        get { return base.AutoSize; }
        set { base.AutoSize = false; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //base.OnPaint(e);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        e.Graphics.Clear(BackColor);
        int h = ClientSize.Height;
        Rectangle rc = new Rectangle(new Point(2, 2), new Size(h - 2, h - 2));
        ControlPaint.DrawCheckBox(e.Graphics, rc,
            Checked ? ButtonState.Checked : ButtonState.Normal);
        Rectangle textRc = new Rectangle(rc.Left + rc.Width + 2, 0, ClientSize.Width - (rc.Left + rc.Width + 2), ClientSize.Height);
        StringFormat sf = new StringFormat();
        switch(TextAlign)
        {
            case ContentAlignment.MiddleLeft:
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                break;
            case ContentAlignment.MiddleRight:
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Center;
                break;

            case ContentAlignment.MiddleCenter:
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                break;
            case ContentAlignment.TopLeft:
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Near;
                break;
            case ContentAlignment.TopCenter:
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Near;
                break;
            case ContentAlignment.TopRight:
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Near;
                break;
            case ContentAlignment.BottomLeft:
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Far;
                break;
            case ContentAlignment.BottomCenter:
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Far;
                break;
            case ContentAlignment.BottomRight:
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Far;
                break;
        }
        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textRc, sf);
    }
}