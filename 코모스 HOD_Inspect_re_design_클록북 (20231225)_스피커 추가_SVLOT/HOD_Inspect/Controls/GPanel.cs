using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

[DefaultEvent( "Click" )]
[Designer( typeof( GPanelDesigner ) )]
public class GPanel : Panel
{
    private Border3DSide borderSide;
    private Border3DStyle border3DStyle;
    private Border3DStyle FirstBorder;
    private Color StartColor = Color.RoyalBlue;
    private Color FinishColor = Color.Azure;
    private float GradientAngle = 0.0F;
    private Font myFont = new Font( "Arial", 10F );
    private string myText = string.Empty;
    private StringAlignment VerAlign;
    private StringAlignment HorAlign;
    private Color BorderColor = Color.Black;
    private ButtonBorderStyle bstyle = ButtonBorderStyle.Solid;
    private int LineWidth = 1;
    private bool MouseAction = false;
    private bool isMarquee = false;
    private bool isRound = false;
    private int Round = 10;
    private int TextLeft = 5;

    // private Task MarqueRun;
    private Timer T = new Timer();

    public GPanel( )
    {
        this.SetStyle( System.Windows.Forms.ControlStyles.AllPaintingInWmPaint
            | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer
            | System.Windows.Forms.ControlStyles.UserPaint, true );
        this.UpdateStyles();
        this.borderSide = System.Windows.Forms.Border3DSide.All;
        this.border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
        //Runmarque();
        //T.Tick += T_Tick;
        //T.Start();
        AllowDrop = false;
    }
    protected override void OnInvalidated( InvalidateEventArgs e )
    {
        base.OnInvalidated( e );
        this.Name = base.Name;
    }
    void GPanel_PropertyChanged( object sender, PropertyChangedEventArgs e )
    {
        base.Name = this.Name;
    }
    
    private void Runmarque()
    {
         Task.Factory.StartNew( () =>
        {
            while (isMarquee)
            {
                if ( isMarquee )
                {
                    this.Invalidate(this.ClientRectangle);
                }

                System.Threading.Thread.Sleep( speed );
                //Application.DoEvents();
            }
        } );
    }

    private void T_Tick( object sender, EventArgs e )
    {
        this.Invalidate( this.ClientRectangle );
    }

    private float MoveX = 0;
    protected override void OnPaintBackground(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        
    }
    protected override void OnPaint( PaintEventArgs e )
    {
        base.OnPaint( e );
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        e.Graphics.InterpolationMode = InterpolationMode.High;
        Rectangle rect = new Rectangle(this.ClientRectangle.Left - 1, this.ClientRectangle.Top - 1
                , this.ClientRectangle.Width + 1, this.ClientRectangle.Height + 1);
        if (!isRound)
        {
            rect = new Rectangle(this.ClientRectangle.Left + 1, this.ClientRectangle.Top + 1
                , this.ClientRectangle.Width - 2, this.ClientRectangle.Height - 2);
            ControlPaint.DrawBorder3D(e.Graphics, this.ClientRectangle, border3DStyle, borderSide);
            if (border3DStyle == System.Windows.Forms.Border3DStyle.Flat)
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, BorderColor, LineWidth, bstyle
                    , BorderColor, LineWidth, bstyle
                    , BorderColor, LineWidth, bstyle
                    , BorderColor, LineWidth, bstyle);

                rect = new Rectangle(this.ClientRectangle.Left + LineWidth, this.ClientRectangle.Top + LineWidth
                    , this.ClientRectangle.Width - LineWidth * 2, this.ClientRectangle.Height - LineWidth * 2);
            }
        }
        using (LinearGradientBrush lgb = new LinearGradientBrush(rect, StartColor, FinishColor, GradientAngle))
        {
            if (isRound)
            {
                Region rg = new Region(GetRoundPath(rect, Round));
                e.Graphics.FillRegion(lgb, rg);
            }
            else e.Graphics.FillRectangle(lgb, rect);

        }
        if (isRound)
            e.Graphics.DrawPath(new Pen(BorderColor, LineWidth), GetRoundPath(rect, Round));

        using (SolidBrush sb = new SolidBrush(this.ForeColor))
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = VerAlign;
            sf.LineAlignment = HorAlign;
            if (!isMarquee)
            {
                Rectangle txtRect = new Rectangle(rect.X + TextLeft, rect.Y, rect.Width - TextLeft, rect.Height);
                e.Graphics.DrawString(myText, this.Font, sb, txtRect, sf);
            }
            else
            {
                e.Graphics.DrawString(myText, this.Font, sb, MoveX, 3);
                MoveX -= 80;
                if (MoveX <= myText.Length * (float)this.Font.Height * -1)
                    MoveX = this.Width;
            }
        }
    }
    public static GraphicsPath GetRoundPath(Rectangle r, int depth)
    {
        GraphicsPath path = new GraphicsPath();

        path.AddArc(r.X, r.Y, depth, depth, 180, 90);
        path.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90);
        path.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90);
        path.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90);
        path.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth / 2);

        return path;
    }
    [Bindable( true ), Category( "TEXT설정" ),
    DefaultValue( false ), Description( "텍스트 이동하도록 설정합니다." )]
    public bool UseMarquee
    {
        get { return isMarquee; }
        set
        {
            isMarquee = value;
            if(isMarquee) Runmarque();
        }
    }

    private int speed = 1000;

    [Bindable( true ), Category( "TEXT설정" ),
    DefaultValue( 100 ), Description( "텍스트 이동속도를 설정합니다. ms" )]
    public int MoveSpeed
    {
        get { return speed; }
        set
        {
            T.Interval = speed;
            speed = value;
        }
    }
    [Bindable(true), Category("TEXT설정"),
    DefaultValue(5), Description("글자의 왼쪽 시작 지점을 설정합니다.")]
    public int TextLeftOffset
    {
        get { return this.TextLeft; }
        set
        {
            if (this.TextLeft != value)
            {
                this.TextLeft = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( Border3DSide.All ), Description( "해당 패널의 경계에 3DStyle 이 적용될 위치를 지정합니다." )]
    public Border3DSide BorderSide
    {
        get { return this.borderSide; }
        set
        {
            if ( this.borderSide != value )
            {
                this.borderSide = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( Border3DStyle.Etched ), Description( "해당 패널의 경계의 3D Style을 지정합니다." )]
    public Border3DStyle Border3DStyle
    {
        get { return this.border3DStyle; }
        set
        {
            if ( this.border3DStyle != value )
            {
                this.border3DStyle = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( typeof( Color ), "Black" ), Description( "해당 패널의 경계색상을 지정합니다. FLAT 모드일때만 동작" )]
    public Color Border색상
    {
        get { return this.BorderColor; }
        set
        {
            if ( this.BorderColor != value )
            {
                this.BorderColor = value;
                this.Invalidate();
            }
        }
    }
    
    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( typeof( ButtonBorderStyle ), "Solid" ), Description( "해당 패널의 경계선 스타일을 지정합니다. FLAT 모드일때만 동작" )]
    public ButtonBorderStyle BorderLineStyle
    {
        get { return this.bstyle; }
        set
        {
            if ( this.bstyle != value )
            {
                this.bstyle = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( 1 ), Description( "해당 패널의 경계선 넓이을 지정합니다. FLAT 모드일때만 동작" )]
    public int BorderLineWidth
    {
        get { return this.LineWidth; }
        set
        {
            if ( this.LineWidth != value )
            {
                this.LineWidth = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "Border Option" ),
    DefaultValue( false ), Description( "마우스동작을 사용한다." )]
    public bool UseMouseAction
    {
        get { return this.MouseAction; }
        set
        {
            if ( this.MouseAction != value )
            {
                this.MouseAction = value;
                this.Invalidate();
            }
        }
    }
    [Bindable(true), Category("Border Option"),
    DefaultValue(false), Description("해당 패널의 모서리 스타일을 지정합니다. 지정시 3D 보더 스타일을 사용하지 못합니다.")]
    public bool isRoundedEdge
    {
        get { return isRound; }
        set
        {
            if (isRound != value)
            {
                isRound = value;
                this.Invalidate();
            }
        }
    }
    [Bindable(true), Category("Border Option"),
    DefaultValue(10), Description("해당 패널의 모서리 라운드 반지름을 지정합니다.")]
    public int RoundRadius
    {
        get { return Round; }
        set
        {
            if (Round != value)
            {
                Round = value;
                this.Invalidate();
            }
        }
    }
    protected override void OnMouseEnter( EventArgs e )
    {
        base.OnMouseEnter( e );
        if ( MouseAction )
        {
            Color sc = StartColor;
            Color ec = FinishColor;
            BeginColor = ec;
            EndColor = sc;
        }
    }

    protected override void OnMouseLeave( EventArgs e )
    {
        base.OnMouseLeave( e );
        if ( MouseAction )
        {
            Color sc = StartColor;
            Color ec = FinishColor;
            BeginColor = ec;
            EndColor = sc;
        }
    }

    protected override void OnMouseDown( MouseEventArgs e )
    {
        base.OnMouseDown( e );
        if ( MouseAction )
        {
            FirstBorder = border3DStyle;
            border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            Color sc = StartColor;
            Color ec = FinishColor;
            BeginColor = ec;
            EndColor = sc;
        }
    }

    protected override void OnMouseUp( MouseEventArgs e )
    {
        base.OnMouseUp( e );
        if ( MouseAction )
        {
            border3DStyle = FirstBorder;
            Color sc = StartColor;
            Color ec = FinishColor;
            BeginColor = ec;
            EndColor = sc;
        }
    }

    private GraphicsPath DrawPanel()
    {
        GraphicsPath mypath = new GraphicsPath( FillMode.Winding );

        mypath.AddRectangle( new Rectangle( this.ClientRectangle.Left + 2, this.ClientRectangle.Top + 2, this.ClientRectangle.Width - 4, this.ClientRectangle.Height - 4 ) );

        PathGradientBrush pgb = new PathGradientBrush( mypath );
        pgb.WrapMode = WrapMode.Clamp;

        return mypath;
    }

    [Bindable( true ), Category( "그라데이션" ),
     Description( "그라데이션의 시작색을 지정합니다." )]
    public Color BeginColor
    {
        get { return StartColor; }
        set
        {
            if ( StartColor != value )
            {
                StartColor = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "그라데이션" ),
     Description( "그라데이션의 종료색을 지정합니다." )]
    public Color EndColor
    {
        get { return FinishColor; }
        set
        {
            if ( FinishColor != value )
            {
                FinishColor = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "그라데이션" ),
    DefaultValue( 0.0F ), Description( "그라데이션의 각도를 지정합니다." )]
    public float GAngle
    {
        get { return GradientAngle; }
        set
        {
            if ( GradientAngle != value )
            {
                GradientAngle = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "TEXT설정" ),
    DefaultValue( "" ), Description( "출력할 TEXT를 입력합니다." )]
    public string TEXT
    {
        get { return myText; }
        set
        {
            if ( myText != value )
            {
                myText = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "TEXT설정" ),
    Description( "출력할 TEXT의 가로정렬을 설정합니다." )]
    public StringAlignment StringAlign
    {
        get { return VerAlign; }
        set
        {
            if ( VerAlign != value )
            {
                VerAlign = value;
                this.Invalidate();
            }
        }
    }

    [Bindable( true ), Category( "TEXT설정" ),
    Description( "출력할 TEXT의 세로정렬을 설정합니다." )]
    public StringAlignment LineAlign
    {
        get { return HorAlign; }
        set
        {
            if ( HorAlign != value )
            {
                HorAlign = value;
                this.Invalidate();
            }
        }
    }
}

internal class GPanelDesigner : System.Windows.Forms.Design.ScrollableControlDesigner
{
    protected override void PreFilterProperties(System.Collections.IDictionary properties)
    {
        properties.Remove("BorderStyle");
    }
}