using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OopsGrocerySystem.util
{
	public enum IconKind { Basket, Eye, EyeOff, Info, Login }

	internal static class Gfx
	{
		public static GraphicsPath RoundRect(RectangleF r, float radius)
		{
			var p = new GraphicsPath();
			float d = Math.Max(0.1f, radius * 2);
			p.AddArc(r.X, r.Y, d, d, 180, 90);
			p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
			p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
			p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
			p.CloseFigure();
			return p;
		}

		public static void DrawIcon(Graphics g, IconKind kind, Rectangle bounds, Color color, float stroke)
		{
			var state = g.Save();
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.TranslateTransform(bounds.X, bounds.Y);
			g.ScaleTransform(bounds.Width / 24f, bounds.Height / 24f);

			using var pen = new Pen(color, stroke)
			{ StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
			using var brush = new SolidBrush(color);

			switch (kind)
			{
				case IconKind.Basket:
					g.DrawArc(pen, 7f, 2f, 10f, 10f, 180, 180);
					g.DrawLine(pen, 7f, 7f, 7f, 11f);
					g.DrawLine(pen, 17f, 7f, 17f, 11f);
					g.DrawLine(pen, 2f, 11f, 22f, 11f);
					g.DrawPolygon(pen, new[] { new PointF(4, 11), new PointF(6, 21), new PointF(18, 21), new PointF(20, 11) });
					g.DrawLine(pen, 9f, 11f, 9f, 21f);
					g.DrawLine(pen, 12f, 11f, 12f, 21f);
					g.DrawLine(pen, 15f, 11f, 15f, 21f);
					g.DrawLine(pen, 5f, 16f, 19f, 16f);
					break;

				case IconKind.Eye:
				case IconKind.EyeOff:
					using (var path = new GraphicsPath())
					{
						path.AddBezier(2, 12, 6, 5, 18, 5, 22, 12);
						path.AddBezier(22, 12, 18, 19, 6, 19, 2, 12);
						g.DrawPath(pen, path);
					}
					g.DrawEllipse(pen, 9f, 9f, 6f, 6f);
					if (kind == IconKind.EyeOff) g.DrawLine(pen, 4f, 20f, 20f, 4f);   // slash
					break;

				case IconKind.Info:
					g.DrawEllipse(pen, 2f, 2f, 20f, 20f);
					g.DrawLine(pen, 12f, 11f, 12f, 17f);
					g.FillEllipse(brush, 11f, 6.5f, 2f, 2f);
					break;

				case IconKind.Login:
					g.DrawLines(pen, new[] { new PointF(14, 4), new PointF(20, 4), new PointF(20, 20), new PointF(14, 20) });
					g.DrawLine(pen, 3f, 12f, 15f, 12f);
					g.DrawLines(pen, new[] { new PointF(10, 7), new PointF(15, 12), new PointF(10, 17) });
					break;
			}
			g.Restore(state);
		}
	}

	public class IconBox : Control
	{
		private IconKind _kind;

		public IconBox()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint |
					 ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.Selectable, false);
			BackColor = Color.Transparent;
			TabStop = false;
		}

		[DefaultValue(IconKind.Basket)]
		public IconKind Kind { get => _kind; set { _kind = value; Invalidate(); } }

		[DefaultValue(1.6f)]
		public float Stroke { get; set; } = 1.6f;

		protected override void OnPaint(PaintEventArgs e) =>
			Gfx.DrawIcon(e.Graphics, _kind, new Rectangle(0, 0, Width, Height), ForeColor, Stroke);
	}

	public class RoundedPanel : Panel
	{
		private Color _fill = Color.White, _border = Color.Gainsboro, _accent = Color.Transparent;
		private float _borderWidth = 1f;
		private int _radius = 6, _accentWidth;

		public RoundedPanel()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
					 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color FillColor { get => _fill; set { _fill = value; Invalidate(); } }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color BorderColor { get => _border; set { _border = value; Invalidate(); } }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public float BorderWidth { get => _borderWidth; set { _borderWidth = value; Invalidate(); } }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color AccentColor { get => _accent; set { _accent = value; Invalidate(); } }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int AccentWidth { get => _accentWidth; set { _accentWidth = value; Invalidate(); } }

		protected override void OnPaint(PaintEventArgs e)
		{
			var g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			using (var bg = new SolidBrush(Parent?.BackColor ?? BackColor))
				g.FillRectangle(bg, ClientRectangle);

			float w = _borderWidth;
			var r = new RectangleF(w / 2f, w / 2f, Width - w - 1, Height - w - 1);
			using var path = Gfx.RoundRect(r, _radius);
			using (var fill = new SolidBrush(_fill)) g.FillPath(fill, path);

			if (_accentWidth > 0)
			{
				var clip = g.Save();
				g.SetClip(path, CombineMode.Intersect);
				using var ab = new SolidBrush(_accent);
				g.FillRectangle(ab, 0, 0, _accentWidth, Height);
				g.Restore(clip);
			}
			if (w > 0)
			{
				using var pen = new Pen(_border, w);
				g.DrawPath(pen, path);
			}
		}
	}

	/// <summary>Flat rounded button with an optional icon (static look only).</summary>
	public class RoundedButton : Button
	{
		public RoundedButton()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
					 ControlStyles.OptimizedDoubleBuffer, true);
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderSize = 0;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color NormalColor { get; set; } = Color.Goldenrod;
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int Radius { get; set; } = 4;
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool ShowIcon { get; set; }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public IconKind Icon { get; set; } = IconKind.Login;

		protected override void OnPaint(PaintEventArgs e)
		{
			var g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.Clear(Parent?.BackColor ?? BackColor);

			using (var path = Gfx.RoundRect(new RectangleF(0, 0, Width - 1, Height - 1), Radius))
			using (var b = new SolidBrush(NormalColor))
				g.FillPath(b, path);

			var size = TextRenderer.MeasureText(g, Text, Font, Size.Empty, TextFormatFlags.NoPadding);
			const int icon = 16, gap = 8;
			int total = size.Width + (ShowIcon ? icon + gap : 0);
			int x = (Width - total) / 2;

			if (ShowIcon)
			{
				Gfx.DrawIcon(g, Icon, new Rectangle(x, (Height - icon) / 2, icon, icon), ForeColor, 1.8f);
				x += icon + gap;
			}
			TextRenderer.DrawText(g, Text, Font, new Rectangle(x, 0, size.Width + 2, Height), ForeColor,
				TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
		}
	}
}