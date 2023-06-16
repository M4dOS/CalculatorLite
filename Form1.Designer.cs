namespace CalculatorLite
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Правка = new System.Windows.Forms.ToolStripMenuItem();
            this.КопироватьSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.КопироватьПамять = new System.Windows.Forms.ToolStripMenuItem();
            this.КопироватьПоле = new System.Windows.Forms.ToolStripMenuItem();
            this.Вставить = new System.Windows.Forms.ToolStripMenuItem();
            this.Справка = new System.Windows.Forms.ToolStripMenuItem();
            this.Инфа = new System.Windows.Forms.ToolStripMenuItem();
            this.Value = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Squart = new System.Windows.Forms.Button();
            this.Inverse = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Equally = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemReplace = new System.Windows.Forms.Button();
            this.MemPlus = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MemMinus = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RootN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Правка,
            this.Справка});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "UpMenu";
            // 
            // Правка
            // 
            this.Правка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КопироватьSelect,
            this.Вставить});
            this.Правка.Font = new System.Drawing.Font("Consolas", 9F);
            this.Правка.Name = "Правка";
            this.Правка.Size = new System.Drawing.Size(61, 20);
            this.Правка.Text = "Правка";
            // 
            // КопироватьSelect
            // 
            this.КопироватьSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КопироватьПамять,
            this.КопироватьПоле});
            this.КопироватьSelect.Name = "КопироватьSelect";
            this.КопироватьSelect.Size = new System.Drawing.Size(180, 22);
            this.КопироватьSelect.Text = "Копировать";
            // 
            // КопироватьПамять
            // 
            this.КопироватьПамять.Name = "КопироватьПамять";
            this.КопироватьПамять.Size = new System.Drawing.Size(186, 22);
            this.КопироватьПамять.Text = "Из памяти";
            this.КопироватьПамять.Click += new System.EventHandler(this.КопироватьПамять_Click);
            // 
            // КопироватьПоле
            // 
            this.КопироватьПоле.Name = "КопироватьПоле";
            this.КопироватьПоле.Size = new System.Drawing.Size(186, 22);
            this.КопироватьПоле.Text = "Из поля значений";
            this.КопироватьПоле.Click += new System.EventHandler(this.КопироватьПоле_Click);
            // 
            // Вставить
            // 
            this.Вставить.Name = "Вставить";
            this.Вставить.Size = new System.Drawing.Size(180, 22);
            this.Вставить.Text = "Вставить";
            this.Вставить.Click += new System.EventHandler(this.Вставить_Click);
            // 
            // Справка
            // 
            this.Справка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Инфа});
            this.Справка.Font = new System.Drawing.Font("Consolas", 9F);
            this.Справка.Name = "Справка";
            this.Справка.Size = new System.Drawing.Size(68, 20);
            this.Справка.Text = "Справка";
            // 
            // Инфа
            // 
            this.Инфа.Name = "Инфа";
            this.Инфа.Size = new System.Drawing.Size(180, 22);
            this.Инфа.Text = "О программе";
            this.Инфа.Click += new System.EventHandler(this.Инфа_Click);
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Value.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Value.Location = new System.Drawing.Point(8, 58);
            this.Value.MaxLength = 32;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(196, 20);
            this.Value.TabIndex = 1;
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.ForestGreen;
            this.Clear.Location = new System.Drawing.Point(170, 118);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(34, 28);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAll.ForeColor = System.Drawing.Color.ForestGreen;
            this.ClearAll.Location = new System.Drawing.Point(170, 150);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(34, 28);
            this.ClearAll.TabIndex = 3;
            this.ClearAll.Text = "CE";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.Backspace.ForeColor = System.Drawing.Color.ForestGreen;
            this.Backspace.Location = new System.Drawing.Point(170, 84);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(34, 28);
            this.Backspace.TabIndex = 4;
            this.Backspace.Text = "←";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num1.Location = new System.Drawing.Point(7, 220);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(34, 28);
            this.Num1.TabIndex = 6;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num2.Location = new System.Drawing.Point(47, 220);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(34, 28);
            this.Num2.TabIndex = 7;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num3.Location = new System.Drawing.Point(87, 220);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(34, 28);
            this.Num3.TabIndex = 8;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Bold);
            this.Divide.ForeColor = System.Drawing.Color.ForestGreen;
            this.Divide.Location = new System.Drawing.Point(130, 116);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(34, 28);
            this.Divide.TabIndex = 9;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Squart
            // 
            this.Squart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Squart.ForeColor = System.Drawing.Color.ForestGreen;
            this.Squart.Location = new System.Drawing.Point(47, 118);
            this.Squart.Name = "Squart";
            this.Squart.Size = new System.Drawing.Size(34, 28);
            this.Squart.TabIndex = 10;
            this.Squart.Text = "√x";
            this.Squart.UseVisualStyleBackColor = true;
            this.Squart.Click += new System.EventHandler(this.Squart_Click);
            // 
            // Inverse
            // 
            this.Inverse.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.Inverse.ForeColor = System.Drawing.Color.ForestGreen;
            this.Inverse.Location = new System.Drawing.Point(7, 118);
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(34, 28);
            this.Inverse.TabIndex = 15;
            this.Inverse.Text = "1/x";
            this.Inverse.UseVisualStyleBackColor = true;
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.Multiplication.ForeColor = System.Drawing.Color.ForestGreen;
            this.Multiplication.Location = new System.Drawing.Point(130, 150);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(34, 28);
            this.Multiplication.TabIndex = 14;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num6.Location = new System.Drawing.Point(87, 185);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(34, 28);
            this.Num6.TabIndex = 13;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num5.Location = new System.Drawing.Point(47, 186);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(34, 28);
            this.Num5.TabIndex = 12;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num4.Location = new System.Drawing.Point(7, 186);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(34, 28);
            this.Num4.TabIndex = 11;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Square
            // 
            this.Square.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Square.ForeColor = System.Drawing.Color.ForestGreen;
            this.Square.Location = new System.Drawing.Point(87, 118);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(34, 28);
            this.Square.TabIndex = 20;
            this.Square.Text = "x²";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.Subtraction.ForeColor = System.Drawing.Color.ForestGreen;
            this.Subtraction.Location = new System.Drawing.Point(130, 186);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(34, 28);
            this.Subtraction.TabIndex = 19;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num9.Location = new System.Drawing.Point(87, 152);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(34, 28);
            this.Num9.TabIndex = 18;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num8.Location = new System.Drawing.Point(47, 151);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(34, 28);
            this.Num8.TabIndex = 17;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num7.Location = new System.Drawing.Point(7, 152);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(34, 28);
            this.Num7.TabIndex = 16;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Equally
            // 
            this.Equally.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.Equally.ForeColor = System.Drawing.Color.ForestGreen;
            this.Equally.Location = new System.Drawing.Point(130, 254);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(74, 28);
            this.Equally.TabIndex = 25;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = true;
            this.Equally.Click += new System.EventHandler(this.Equally_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Addition.ForeColor = System.Drawing.Color.ForestGreen;
            this.Addition.Location = new System.Drawing.Point(130, 219);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(34, 28);
            this.Addition.TabIndex = 24;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Comma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Comma.Location = new System.Drawing.Point(47, 254);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(34, 28);
            this.Comma.TabIndex = 23;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.PlusMinus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PlusMinus.Location = new System.Drawing.Point(87, 254);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(34, 28);
            this.PlusMinus.TabIndex = 22;
            this.PlusMinus.Text = "±";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Num0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Num0.Location = new System.Drawing.Point(7, 254);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(34, 28);
            this.Num0.TabIndex = 21;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.Enabled = false;
            this.MemoryClear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryClear.ForeColor = System.Drawing.Color.ForestGreen;
            this.MemoryClear.Location = new System.Drawing.Point(7, 84);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(34, 28);
            this.MemoryClear.TabIndex = 26;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = true;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // MemReplace
            // 
            this.MemReplace.Enabled = false;
            this.MemReplace.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemReplace.ForeColor = System.Drawing.Color.ForestGreen;
            this.MemReplace.Location = new System.Drawing.Point(47, 84);
            this.MemReplace.Name = "MemReplace";
            this.MemReplace.Size = new System.Drawing.Size(34, 28);
            this.MemReplace.TabIndex = 27;
            this.MemReplace.Text = "MR";
            this.MemReplace.UseVisualStyleBackColor = true;
            this.MemReplace.Click += new System.EventHandler(this.MemReplace_Click);
            // 
            // MemPlus
            // 
            this.MemPlus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemPlus.ForeColor = System.Drawing.Color.ForestGreen;
            this.MemPlus.Location = new System.Drawing.Point(87, 84);
            this.MemPlus.Name = "MemPlus";
            this.MemPlus.Size = new System.Drawing.Size(34, 28);
            this.MemPlus.TabIndex = 29;
            this.MemPlus.Text = "M+";
            this.MemPlus.UseVisualStyleBackColor = true;
            this.MemPlus.Click += new System.EventHandler(this.MemPlus_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // MemMinus
            // 
            this.MemMinus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemMinus.ForeColor = System.Drawing.Color.ForestGreen;
            this.MemMinus.Location = new System.Drawing.Point(130, 84);
            this.MemMinus.Name = "MemMinus";
            this.MemMinus.Size = new System.Drawing.Size(34, 28);
            this.MemMinus.TabIndex = 31;
            this.MemMinus.Text = "M-";
            this.MemMinus.UseVisualStyleBackColor = true;
            this.MemMinus.Click += new System.EventHandler(this.MemMinus_Click);
            // 
            // Pow
            // 
            this.Pow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pow.ForeColor = System.Drawing.Color.ForestGreen;
            this.Pow.Location = new System.Drawing.Point(170, 186);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(34, 28);
            this.Pow.TabIndex = 32;
            this.Pow.Text = "xⁿ";
            this.Pow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.DetectUrls = false;
            this.panel1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(62, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.MaxLength = 64;
            this.panel1.Multiline = false;
            this.panel1.Name = "panel1";
            this.panel1.ReadOnly = true;
            this.panel1.Size = new System.Drawing.Size(142, 16);
            this.panel1.TabIndex = 33;
            this.panel1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Память:";
            // 
            // RootN
            // 
            this.RootN.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.RootN.ForeColor = System.Drawing.Color.ForestGreen;
            this.RootN.Location = new System.Drawing.Point(170, 219);
            this.RootN.Name = "RootN";
            this.RootN.Size = new System.Drawing.Size(34, 28);
            this.RootN.TabIndex = 35;
            this.RootN.Text = "ⁿ√x";
            this.RootN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(215, 292);
            this.Controls.Add(this.RootN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.MemMinus);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.MemPlus);
            this.Controls.Add(this.MemReplace);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.Equally);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Inverse);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Squart);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CalculatorLite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Правка;
        private System.Windows.Forms.ToolStripMenuItem КопироватьSelect;
        private System.Windows.Forms.ToolStripMenuItem Вставить;
        private System.Windows.Forms.ToolStripMenuItem Справка;
        private System.Windows.Forms.ToolStripMenuItem Инфа;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Squart;
        private System.Windows.Forms.Button Inverse;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Equally;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button MemReplace;
        private System.Windows.Forms.Button MemPlus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem КопироватьПамять;
        private System.Windows.Forms.ToolStripMenuItem КопироватьПоле;
        private System.Windows.Forms.Button MemMinus;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.RichTextBox panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RootN;
    }
}

