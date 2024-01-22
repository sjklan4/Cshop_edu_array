using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SListBox : ListBox
{
    public SListBox()
    {
        this.Height = 30;
    }
    private Color fColor = Color.White;
    private Color SColor = Color.White;
    private Color SelColor = SystemColors.ActiveCaption;
    public Color FirstRowColor
    {
        get { return fColor; }
        set { fColor = value; Refresh(); }
    }
    public Color SecondRowColor
    {
        get { return SColor; }
        set { SColor = value; Refresh(); }
    }
    public Color SelectedColor
    {
        get { return SelColor; }
        set { SelColor = value; Refresh(); }
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
     
        if (this.Items.Count == 0) return;
        var item = (string)this.Items[e.Index];
        if (e.Index % 2 == 1)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(SelColor), e.Bounds);
            else e.Graphics.FillRectangle(new SolidBrush(SColor), e.Bounds);
        }
        else
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(SelColor), e.Bounds);
            else e.Graphics.FillRectangle(new SolidBrush(fColor), e.Bounds);
        }
        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Near;
        sf.LineAlignment = StringAlignment.Center;
        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            e.Graphics.DrawString($"{e.Index + 1} | {item}", e.Font, new SolidBrush(Color.FromArgb( e.ForeColor.R >> 1, e.ForeColor.G >> 1, e.ForeColor.B >> 1)), e.Bounds, sf);
        else e.Graphics.DrawString($"{e.Index + 1} | {item}", e.Font, new SolidBrush(e.ForeColor), e.Bounds, sf);
        base.OnDrawItem(e);

    }
}
