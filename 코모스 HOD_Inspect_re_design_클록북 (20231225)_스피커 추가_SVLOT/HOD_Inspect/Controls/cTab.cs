using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VisionInspector
{
    public class cTab : TabControl
    {
       
        [DllImportAttribute("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

        private Color BColorF = Color.White;
        private Color BColorS = Color.Black;
        private Color FColor = Color.Black;
        private Color SelBColorF = Color.White;
        private Color SelBColorS = Color.Black;
        private Color SColor = Color.Yellow;
        private LinearGradientMode GMode = LinearGradientMode.Vertical;

        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(this.Handle, "", "");
            base.OnHandleCreated(e);
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "White"), Description("그라데이션 시작색")]
        public Color BackColorF
        {
            get { return BColorF; }
            set
            {
                BColorF = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "Black"), Description("그라데이션 종료색")]
        public Color BackColorS
        {
            get { return BColorS; }
            set
            {
                BColorS = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "Black"), Description("글자색")]
        public Color FontColor
        {
            get { return FColor; }
            set
            {
                FColor = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "White"), Description("선택된 탭의 그라데이션 시작색")]
        public Color SelectBackColorF
        {
            get { return SelBColorF; }
            set
            {
                SelBColorF = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "Black"), Description("선택된 탭의 그라데이션 종료색")]
        public Color SelectBackColorS
        {
            get { return SelBColorS; }
            set
            {
                SelBColorS = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(Color), "Yellow"), Description("선택된 탭의 글자색")]
        public Color SelectColor
        {
            get { return SColor; }
            set
            {
                SColor = value; this.Invalidate();
            }
        }

        [Bindable(true), Category("그라데이션"),
        DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("그라데이션 모드")]
        public LinearGradientMode GradientMode
        {
            get { return GMode; }
            set { GMode = value; this.Invalidate(); }
        }
       
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            RepaintControls(this, e);
        }

        private void RepaintControls(object sender, DrawItemEventArgs e)
        {
            Font font;
            Brush back_brush;
            Brush fore_brush;
            LinearGradientBrush MyLinGradBrush;
            Rectangle bounds = this.GetTabRect(e.Index);

            if (e.Index == this.SelectedIndex)
            {
                font = new Font(e.Font, e.Font.Style);
                bounds = new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height);// - this.Padding.Y);
                MyLinGradBrush = new LinearGradientBrush(bounds, SelBColorF, SelBColorS, GMode);
                back_brush = MyLinGradBrush;
                fore_brush = new SolidBrush(SColor);
            }
            else
            {
                font = new Font(e.Font, e.Font.Style & FontStyle.Bold);
                bounds = new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height);// - this.Padding.Y);
                MyLinGradBrush = new LinearGradientBrush(bounds, BColorF, BColorS, GMode);
                back_brush = MyLinGradBrush;
                fore_brush = new SolidBrush(FColor);
            }

            string tab_name = this.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(back_brush, bounds);
            e.Graphics.DrawString(tab_name, font, fore_brush, bounds, sf);

            sf.Dispose();
            back_brush.Dispose();
            fore_brush.Dispose();
            font.Dispose();
        }

        protected void PaintTransparentBackground(Graphics graphics, Rectangle clipRect)
        {
            graphics.Clear(Color.Transparent);
            if ((this.Parent != null))
            {
                clipRect.Offset(this.Location);
                PaintEventArgs e = new PaintEventArgs(graphics, clipRect);
                GraphicsState state = graphics.Save();
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                try
                {
                    graphics.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);
                }
                finally
                {
                    graphics.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }
        }
    }
}