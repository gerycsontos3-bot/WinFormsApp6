using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // ---- Colors (Windows 11 light style) ----
        static readonly Color BgColor = Color.FromArgb(243, 243, 243);
        static readonly Color NumColor = Color.White;
        static readonly Color NumHover = Color.FromArgb(245, 245, 245);
        static readonly Color KeyColor = Color.FromArgb(250, 250, 250);
        static readonly Color KeyHover = Color.FromArgb(235, 235, 235);
        static readonly Color AccentColor = Color.FromArgb(0, 103, 192);
        static readonly Color AccentHover = Color.FromArgb(25, 117, 197);
        static readonly Color BorderColor = Color.FromArgb(224, 224, 224);
        static readonly Color SubText = Color.FromArgb(95, 95, 95);

        // ---- State ----
        string current = "0";
        decimal? acc = null;
        string? op = null;
        bool fresh = true;
        bool error = false;
        string expr = "";
        decimal memory = 0;
        bool hasMemory = false;
        int valueFontSize = 0;

        public Form1()
        {
            InitializeComponent();
            ApplyStyle();
            Render();
        }

        // ---------- Styling ----------
        void ApplyStyle()
        {
            BackColor = BgColor;
            mainLayout.BackColor = BgColor;
            exprLabel.ForeColor = SubText;
            exprLabel.Font = new Font("Segoe UI", 10F);
            valueLabel.ForeColor = Color.FromArgb(26, 26, 26);

            foreach (Button b in padLayout.Controls.OfType<Button>())
            {
                bool isEquals = b == btnEq;
                bool isNumber = b.Text.Length == 1 &&
                                (char.IsDigit(b.Text[0]) || b.Text == "." || b.Text == "±");

                b.FlatStyle = FlatStyle.Flat;
                b.Cursor = Cursors.Hand;
                b.Font = new Font(isNumber ? "Segoe UI Semibold" : "Segoe UI", 14F);
                b.BackColor = isEquals ? AccentColor : isNumber ? NumColor : KeyColor;
                b.ForeColor = isEquals ? Color.White : Color.FromArgb(26, 26, 26);
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = isEquals ? AccentColor : BorderColor;
                b.FlatAppearance.MouseOverBackColor = isEquals ? AccentHover : isNumber ? NumHover : KeyHover;
                b.FlatAppearance.MouseDownBackColor = isEquals ? AccentHover : KeyHover;
            }

            foreach (Button b in memLayout.Controls.OfType<Button>())
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = KeyHover;
                b.BackColor = BgColor;
                b.Font = new Font("Segoe UI", 9.5F);
            }
        }

        // ---------- Click handlers ----------
        void Key_Click(object? sender, EventArgs e)
        {
            if (sender is Button b) Press(b.Text);
        }

        void Mem_Click(object? sender, EventArgs e)
        {
            if (sender is Button b) MemoryPress(b.Text);
        }

        // ---------- Display ----------
        static string Fmt(string s)
        {
            bool neg = s.StartsWith('-');
            if (neg) s = s[1..];
            string[] parts = s.Split('.');
            var sb = new StringBuilder();
            string intPart = parts[0];
            for (int i = 0; i < intPart.Length; i++)
            {
                if (i > 0 && (intPart.Length - i) % 3 == 0) sb.Append(',');
                sb.Append(intPart[i]);
            }
            string result = sb.ToString();
            if (parts.Length > 1) result += "." + parts[1];
            return (neg ? "-" : "") + result;
        }

        static string Num(decimal x) =>
            x.ToString("0.##############", CultureInfo.InvariantCulture);

        static decimal Parse(string s) =>
            decimal.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture);

        void Render()
        {
            string text = error ? current : Fmt(current);
            valueLabel.Text = text;

            int size = 32;
            if (text.Length > 10) size = Math.Max(14, 32 * 10 / text.Length);
            if (size != valueFontSize)
            {
                valueFontSize = size;
                valueLabel.Font = new Font("Segoe UI Semibold", size, FontStyle.Regular, GraphicsUnit.Point);
            }

            exprLabel.Text = expr;
            btnMC.Enabled = hasMemory;
            btnMR.Enabled = hasMemory;
        }

        // ---------- Calculator logic ----------
        void SetError(string message)
        {
            current = message;
            acc = null;
            op = null;
            expr = "";
            fresh = true;
            error = true;
            Render();
        }

        void ClearAll()
        {
            current = "0";
            acc = null;
            op = null;
            expr = "";
            fresh = true;
            error = false;
            Render();
        }

        void Digit(string d)
        {
            if (error) ClearAll();
            if (fresh)
            {
                current = d;
                fresh = false;
            }
            else if (current.Count(char.IsDigit) < 16)
            {
                current = current == "0" ? d : current + d;
            }
            Render();
        }

        void Dot()
        {
            if (error) ClearAll();
            if (fresh)
            {
                current = "0.";
                fresh = false;
            }
            else if (!current.Contains('.'))
            {
                current += ".";
            }
            Render();
        }

        static decimal Apply(decimal a, string o, decimal b) => o switch
        {
            "+" => a + b,
            "−" => a - b,
            "×" => a * b,
            "÷" => a / b,
            _ => b
        };

        void Operator(string o)
        {
            if (error) return;
            try
            {
                if (op != null && !fresh)
                {
                    decimal r = Apply(acc!.Value, op, Parse(current));
                    acc = r;
                    current = Num(r);
                }
                else
                {
                    acc = Parse(current);
                }
            }
            catch (DivideByZeroException) { SetError("Cannot divide by zero"); return; }
            catch (OverflowException) { SetError("Overflow"); return; }

            op = o;
            expr = Fmt(Num(acc!.Value)) + " " + o;
            fresh = true;
            Render();
        }

        void Calculate()
        {
            if (error) return;
            if (op == null)
            {
                expr = Fmt(current) + " =";
                fresh = true;
                Render();
                return;
            }

            decimal a = acc!.Value;
            decimal b = Parse(current);
            string o = op;
            try
            {
                decimal r = Apply(a, o, b);
                expr = Fmt(Num(a)) + " " + o + " " + Fmt(Num(b)) + " =";
                current = Num(r);
            }
            catch (DivideByZeroException) { SetError("Cannot divide by zero"); return; }
            catch (OverflowException) { SetError("Overflow"); return; }

            acc = null;
            op = null;
            fresh = true;
            Render();
        }

        void Unary(string f)
        {
            if (error) return;
            decimal x = Parse(current);
            decimal r;
            string label;
            try
            {
                switch (f)
                {
                    case "1/x":
                        if (x == 0) { SetError("Cannot divide by zero"); return; }
                        r = 1 / x;
                        label = "1/";
                        break;
                    case "x²":
                        r = x * x;
                        label = "sqr";
                        break;
                    default: // √x
                        if (x < 0) { SetError("Invalid input"); return; }
                        r = (decimal)Math.Sqrt((double)x);
                        label = "√";
                        break;
                }
            }
            catch (OverflowException) { SetError("Overflow"); return; }

            expr = label + "(" + Fmt(Num(x)) + ")";
            current = Num(r);
            fresh = true;
            Render();
        }

        void Percent()
        {
            if (error) return;
            decimal x = Parse(current);
            decimal r = acc.HasValue ? acc.Value * x / 100 : 0;
            current = Num(r);
            fresh = true;
            Render();
        }

        void Backspace()
        {
            if (error) { ClearAll(); return; }
            if (fresh) return;
            current = current.Length > 1 && !(current.Length == 2 && current[0] == '-')
                ? current[..^1]
                : "0";
            if (current == "0") fresh = true;
            Render();
        }

        void ToggleSign()
        {
            if (error) return;
            if (current != "0")
                current = current[0] == '-' ? current[1..] : "-" + current;
            Render();
        }

        void Press(string k)
        {
            if (k.Length == 1 && char.IsDigit(k[0])) { Digit(k); return; }
            switch (k)
            {
                case ".": Dot(); break;
                case "+": case "−": case "×": case "÷": Operator(k); break;
                case "=": Calculate(); break;
                case "C": ClearAll(); break;
                case "CE": current = "0"; fresh = true; error = false; Render(); break;
                case "⌫": Backspace(); break;
                case "±": ToggleSign(); break;
                case "%": Percent(); break;
                case "1/x": case "x²": case "√x": Unary(k); break;
            }
        }

        void MemoryPress(string m)
        {
            if (error) return;
            decimal x = Parse(current);
            switch (m)
            {
                case "MC": memory = 0; hasMemory = false; break;
                case "MR": current = Num(memory); fresh = true; break;
                case "M+": memory += x; hasMemory = true; fresh = true; break;
                case "M−": memory -= x; hasMemory = true; fresh = true; break;
                case "MS": memory = x; hasMemory = true; fresh = true; break;
            }
            Render();
        }

        // ---------- Keyboard ----------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: Press("="); return true;
                case Keys.Escape: Press("C"); return true;
                case Keys.Back: Press("⌫"); return true;
                case Keys.Delete: Press("CE"); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            string? k = e.KeyChar switch
            {
                >= '0' and <= '9' => e.KeyChar.ToString(),
                '.' or ',' => ".",
                '+' => "+",
                '-' => "−",
                '*' => "×",
                '/' => "÷",
                '=' => "=",
                '%' => "%",
                _ => null
            };
            if (k != null)
            {
                Press(k);
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}