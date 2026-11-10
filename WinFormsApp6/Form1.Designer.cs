namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            exprLabel = new Label();
            valueLabel = new Label();
            memLayout = new TableLayoutPanel();
            btnMC = new Button();
            btnMR = new Button();
            btnMPlus = new Button();
            btnMMinus = new Button();
            btnMS = new Button();
            padLayout = new TableLayoutPanel();
            btnPercent = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnBack = new Button();
            btnInv = new Button();
            btnSqr = new Button();
            btnSqrt = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEq = new Button();
            mainLayout.SuspendLayout();
            memLayout.SuspendLayout();
            padLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(exprLabel, 0, 0);
            mainLayout.Controls.Add(valueLabel, 0, 1);
            mainLayout.Controls.Add(memLayout, 0, 2);
            mainLayout.Controls.Add(padLayout, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(6);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(340, 530);
            mainLayout.TabIndex = 0;
            // 
            // exprLabel
            // 
            exprLabel.Dock = DockStyle.Fill;
            exprLabel.Location = new Point(9, 6);
            exprLabel.Name = "exprLabel";
            exprLabel.Padding = new Padding(0, 0, 10, 0);
            exprLabel.Size = new Size(322, 26);
            exprLabel.TabIndex = 0;
            exprLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // valueLabel
            // 
            valueLabel.Dock = DockStyle.Fill;
            valueLabel.Location = new Point(9, 32);
            valueLabel.Name = "valueLabel";
            valueLabel.Padding = new Padding(0, 0, 10, 0);
            valueLabel.Size = new Size(322, 84);
            valueLabel.TabIndex = 1;
            valueLabel.Text = "0";
            valueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // memLayout
            // 
            memLayout.ColumnCount = 5;
            memLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            memLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            memLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            memLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            memLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            memLayout.Controls.Add(btnMC, 0, 0);
            memLayout.Controls.Add(btnMR, 1, 0);
            memLayout.Controls.Add(btnMPlus, 2, 0);
            memLayout.Controls.Add(btnMMinus, 3, 0);
            memLayout.Controls.Add(btnMS, 4, 0);
            memLayout.Dock = DockStyle.Fill;
            memLayout.Location = new Point(6, 116);
            memLayout.Margin = new Padding(0);
            memLayout.Name = "memLayout";
            memLayout.RowCount = 1;
            memLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            memLayout.Size = new Size(328, 34);
            memLayout.TabIndex = 2;
            // 
            // btnMC
            // 
            btnMC.Dock = DockStyle.Fill;
            btnMC.Location = new Point(1, 1);
            btnMC.Margin = new Padding(1);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(63, 32);
            btnMC.TabIndex = 0;
            btnMC.TabStop = false;
            btnMC.Text = "MC";
            btnMC.Click += Mem_Click;
            // 
            // btnMR
            // 
            btnMR.Dock = DockStyle.Fill;
            btnMR.Location = new Point(66, 1);
            btnMR.Margin = new Padding(1);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(63, 32);
            btnMR.TabIndex = 1;
            btnMR.TabStop = false;
            btnMR.Text = "MR";
            btnMR.Click += Mem_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.Dock = DockStyle.Fill;
            btnMPlus.Location = new Point(131, 1);
            btnMPlus.Margin = new Padding(1);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(63, 32);
            btnMPlus.TabIndex = 2;
            btnMPlus.TabStop = false;
            btnMPlus.Text = "M+";
            btnMPlus.Click += Mem_Click;
            // 
            // btnMMinus
            // 
            btnMMinus.Dock = DockStyle.Fill;
            btnMMinus.Location = new Point(196, 1);
            btnMMinus.Margin = new Padding(1);
            btnMMinus.Name = "btnMMinus";
            btnMMinus.Size = new Size(63, 32);
            btnMMinus.TabIndex = 3;
            btnMMinus.TabStop = false;
            btnMMinus.Text = "M−";
            btnMMinus.Click += Mem_Click;
            // 
            // btnMS
            // 
            btnMS.Dock = DockStyle.Fill;
            btnMS.Location = new Point(261, 1);
            btnMS.Margin = new Padding(1);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(66, 32);
            btnMS.TabIndex = 4;
            btnMS.TabStop = false;
            btnMS.Text = "MS";
            btnMS.Click += Mem_Click;
            // 
            // padLayout
            // 
            padLayout.ColumnCount = 4;
            padLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            padLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            padLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            padLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            padLayout.Controls.Add(btnPercent, 0, 0);
            padLayout.Controls.Add(btnCE, 1, 0);
            padLayout.Controls.Add(btnC, 2, 0);
            padLayout.Controls.Add(btnBack, 3, 0);
            padLayout.Controls.Add(btnInv, 0, 1);
            padLayout.Controls.Add(btnSqr, 1, 1);
            padLayout.Controls.Add(btnSqrt, 2, 1);
            padLayout.Controls.Add(btnDiv, 3, 1);
            padLayout.Controls.Add(btn7, 0, 2);
            padLayout.Controls.Add(btn8, 1, 2);
            padLayout.Controls.Add(btn9, 2, 2);
            padLayout.Controls.Add(btnMul, 3, 2);
            padLayout.Controls.Add(btn4, 0, 3);
            padLayout.Controls.Add(btn5, 1, 3);
            padLayout.Controls.Add(btn6, 2, 3);
            padLayout.Controls.Add(btnSub, 3, 3);
            padLayout.Controls.Add(btn1, 0, 4);
            padLayout.Controls.Add(btn2, 1, 4);
            padLayout.Controls.Add(btn3, 2, 4);
            padLayout.Controls.Add(btnAdd, 3, 4);
            padLayout.Controls.Add(btnSign, 0, 5);
            padLayout.Controls.Add(btn0, 1, 5);
            padLayout.Controls.Add(btnDot, 2, 5);
            padLayout.Controls.Add(btnEq, 3, 5);
            padLayout.Dock = DockStyle.Fill;
            padLayout.Location = new Point(6, 150);
            padLayout.Margin = new Padding(0);
            padLayout.Name = "padLayout";
            padLayout.RowCount = 6;
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            padLayout.Size = new Size(328, 374);
            padLayout.TabIndex = 3;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Location = new Point(2, 2);
            btnPercent.Margin = new Padding(2);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(78, 58);
            btnPercent.TabIndex = 0;
            btnPercent.TabStop = false;
            btnPercent.Text = "%";
            btnPercent.Click += Key_Click;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.Location = new Point(84, 2);
            btnCE.Margin = new Padding(2);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(78, 58);
            btnCE.TabIndex = 1;
            btnCE.TabStop = false;
            btnCE.Text = "CE";
            btnCE.Click += Key_Click;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Location = new Point(166, 2);
            btnC.Margin = new Padding(2);
            btnC.Name = "btnC";
            btnC.Size = new Size(78, 58);
            btnC.TabIndex = 2;
            btnC.TabStop = false;
            btnC.Text = "C";
            btnC.Click += Key_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(248, 2);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 58);
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.Text = "⌫";
            btnBack.Click += Key_Click;
            // 
            // btnInv
            // 
            btnInv.Dock = DockStyle.Fill;
            btnInv.Location = new Point(2, 64);
            btnInv.Margin = new Padding(2);
            btnInv.Name = "btnInv";
            btnInv.Size = new Size(78, 58);
            btnInv.TabIndex = 4;
            btnInv.TabStop = false;
            btnInv.Text = "1/x";
            btnInv.Click += Key_Click;
            // 
            // btnSqr
            // 
            btnSqr.Dock = DockStyle.Fill;
            btnSqr.Location = new Point(84, 64);
            btnSqr.Margin = new Padding(2);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(78, 58);
            btnSqr.TabIndex = 5;
            btnSqr.TabStop = false;
            btnSqr.Text = "x²";
            btnSqr.Click += Key_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.Location = new Point(166, 64);
            btnSqrt.Margin = new Padding(2);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(78, 58);
            btnSqrt.TabIndex = 6;
            btnSqrt.TabStop = false;
            btnSqrt.Text = "√x";
            btnSqrt.Click += Key_Click;
            // 
            // btnDiv
            // 
            btnDiv.Dock = DockStyle.Fill;
            btnDiv.Location = new Point(248, 64);
            btnDiv.Margin = new Padding(2);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(78, 58);
            btnDiv.TabIndex = 7;
            btnDiv.TabStop = false;
            btnDiv.Text = "÷";
            btnDiv.Click += Key_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(2, 126);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 58);
            btn7.TabIndex = 8;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.Click += Key_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(84, 126);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 58);
            btn8.TabIndex = 9;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.Click += Key_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(166, 126);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 58);
            btn9.TabIndex = 10;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.Click += Key_Click;
            // 
            // btnMul
            // 
            btnMul.Dock = DockStyle.Fill;
            btnMul.Location = new Point(248, 126);
            btnMul.Margin = new Padding(2);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(78, 58);
            btnMul.TabIndex = 11;
            btnMul.TabStop = false;
            btnMul.Text = "×";
            btnMul.Click += Key_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(2, 188);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 58);
            btn4.TabIndex = 12;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.Click += Key_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(84, 188);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 58);
            btn5.TabIndex = 13;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.Click += Key_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(166, 188);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 58);
            btn6.TabIndex = 14;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.Click += Key_Click;
            // 
            // btnSub
            // 
            btnSub.Dock = DockStyle.Fill;
            btnSub.Location = new Point(248, 188);
            btnSub.Margin = new Padding(2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(78, 58);
            btnSub.TabIndex = 15;
            btnSub.TabStop = false;
            btnSub.Text = "−";
            btnSub.Click += Key_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(2, 250);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 58);
            btn1.TabIndex = 16;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.Click += Key_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(84, 250);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 58);
            btn2.TabIndex = 17;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.Click += Key_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(166, 250);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 58);
            btn3.TabIndex = 18;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.Click += Key_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(248, 250);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 58);
            btnAdd.TabIndex = 19;
            btnAdd.TabStop = false;
            btnAdd.Text = "+";
            btnAdd.Click += Key_Click;
            // 
            // btnSign
            // 
            btnSign.Dock = DockStyle.Fill;
            btnSign.Location = new Point(2, 312);
            btnSign.Margin = new Padding(2);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(78, 60);
            btnSign.TabIndex = 20;
            btnSign.TabStop = false;
            btnSign.Text = "±";
            btnSign.Click += Key_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(84, 312);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 60);
            btn0.TabIndex = 21;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.Click += Key_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Location = new Point(166, 312);
            btnDot.Margin = new Padding(2);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(78, 60);
            btnDot.TabIndex = 22;
            btnDot.TabStop = false;
            btnDot.Text = ".";
            btnDot.Click += Key_Click;
            // 
            // btnEq
            // 
            btnEq.Dock = DockStyle.Fill;
            btnEq.Location = new Point(248, 312);
            btnEq.Margin = new Padding(2);
            btnEq.Name = "btnEq";
            btnEq.Size = new Size(78, 60);
            btnEq.TabIndex = 23;
            btnEq.TabStop = false;
            btnEq.Text = "=";
            btnEq.Click += Key_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 530);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contos Gergő";
            Load += Form1_Load;
            mainLayout.ResumeLayout(false);
            memLayout.ResumeLayout(false);
            padLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label exprLabel;
        private Label valueLabel;
        private TableLayoutPanel memLayout;
        private Button btnMC;
        private Button btnMR;
        private Button btnMPlus;
        private Button btnMMinus;
        private Button btnMS;
        private TableLayoutPanel padLayout;
        private Button btnPercent;
        private Button btnCE;
        private Button btnC;
        private Button btnBack;
        private Button btnInv;
        private Button btnSqr;
        private Button btnSqrt;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnSign;
        private Button btn0;
        private Button btnDot;
        private Button btnEq;
    }
}