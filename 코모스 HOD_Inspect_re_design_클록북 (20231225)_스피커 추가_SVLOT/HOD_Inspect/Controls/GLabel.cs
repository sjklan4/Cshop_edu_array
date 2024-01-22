using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GLabel : Label
{
    private Color StartColor = Color.RoyalBlue;
    private Color FinishColor = Color.Azure;
    private float GradientAngle = 0.0F;
    private bool EllipseMode = false;

    public GLabel()
    {
        this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint
            | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer
            | System.Windows.Forms.ControlStyles.UserPaint, true);
        this.UpdateStyles();
        AllowDrop = false;
    }
   
    protected override void OnPaint(PaintEventArgs e)
    {
        // SmoothingMode smooth = e.Graphics.SmoothingMode;
        Rectangle rect = this.ClientRectangle;
        using (LinearGradientBrush lgb = new LinearGradientBrush(rect, StartColor, FinishColor, GradientAngle))
        {
            e.Graphics.FillRectangle(lgb, rect);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
        if (EllipseMode)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(this.ClientRectangle);
                //e.Graphics.DrawPath( new Pen( this.ForeColor ,1), path );
                this.Region = new Region(path);
            }
        }
        else this.Region = new Region(rect);
        base.OnPaint(e);
    }

    [Bindable(true), Category("LayOut"), DefaultValue(false), Description("원형으로 변경할지 설정합니다.")]
    public bool isEllipse
    {
        get { return EllipseMode; }
        set
        {
            EllipseMode = value;
            this.Invalidate();
        }
    }

    [Bindable(true), Category("그라데이션"), Description("그라데이션의 시작색을 지정합니다.")]
    public Color BeginColor
    {
        get { return StartColor; }
        set
        {
            if (StartColor != value)
            {
                StartColor = value;
                this.Invalidate();
            }
        }
    }

    [Bindable(true), Category("그라데이션"), Description("그라데이션의 종료색을 지정합니다.")]
    public Color EndColor
    {
        get { return FinishColor; }
        set
        {
            if (FinishColor != value)
            {
                FinishColor = value;
                this.Invalidate();
            }
        }
    }

    [Bindable(true), Category("그라데이션"), DefaultValue(0.0F), Description("그라데이션의 각도를 지정합니다.")]
    public float GAngle
    {
        get { return GradientAngle; }
        set
        {
            if (GradientAngle != value)
            {
                GradientAngle = value;
                this.Invalidate();
            }
        }
    }
}