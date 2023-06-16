using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorLite
{
    public partial class Form1 : Form
    {
        #region Переменные
        string operation;//операции (+ - * / ^) 
        State CurrentState;//текущий статус 
        double? memory;//память
        double answer;//хранение значения
        enum State
        {
            NoState = -1,
            Substraction,
            Addiction,
            Multiplication,
            Divide,
            Power
        }

        public Form1()
        {
            InitializeComponent();
            memory = null;
            answer = 0;
            Value.Text = "0";
            Value.SelectionStart = Value.Text.Length;
            CurrentState = State.NoState;
            Вставить.Enabled = Clipboard.GetText() != "";
            КопироватьПамять.Enabled = memory != null; 
            КопироватьПоле.Enabled = Value.Text != string.Empty;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Equally_Click(sender, e); break;
                case Keys.NumPad0:
                case Keys.D0:
                    Num0_Click(sender, e); break;
                case Keys.NumPad1:
                case Keys.D1:
                    Num1_Click(sender, e); break;
                case Keys.NumPad2:
                case Keys.D2:
                    Num2_Click(sender, e); break;
                case Keys.NumPad3:
                case Keys.D3:
                    Num3_Click(sender, e); break;
                case Keys.NumPad4:
                case Keys.D4:
                    Num4_Click(sender, e); break;
                case Keys.NumPad5:
                case Keys.D5:
                    Num5_Click(sender, e); break;
                case Keys.NumPad6:
                case Keys.D6:
                    Num6_Click(sender, e); break;
                case Keys.NumPad7:
                case Keys.D7:
                    Num7_Click(sender, e); break;
                case Keys.NumPad8:
                case Keys.D8:
                    Num8_Click(sender, e); break;
                case Keys.NumPad9:
                case Keys.D9:
                    Num9_Click(sender, e); break;
                case Keys.Add:
                    Addition_Click(sender, e); break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                case Keys.OemPeriod:
                    Comma_Click(sender, e); break;
                case Keys.Subtract:
                    Subtraction_Click(sender,e);break;
                case Keys.Divide:
                    Divide_Click(sender, e);break;
                case Keys.Multiply:
                    Multiplication_Click(sender, e); break;
                case Keys.OemMinus:
                    MemMinus_Click(sender, e);break;
                case Keys.Oemplus:
                    MemPlus_Click(sender, e);break;
                case Keys.Back:
                    Backspace_Click(sender, e);break;
                case Keys.Delete:
                    ClearAll_Click(sender, e); break;

            }
        }
        #endregion

        #region Память
        private void MemPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(Value.Text) != null)
                {
                    MemoryClear.Enabled = true;
                    MemReplace.Enabled = true;
                    
                    if(memory != null) memory += double.Parse(Value.Text);
                    else memory = double.Parse(Value.Text);

                    panel1.Text = memory.ToString();

                    КопироватьПамять.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Попытайтесь ввести корректные для данной операции данные и повторите попытку", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }
        }
        private void MemMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(Value.Text) != null)
                {
                    MemoryClear.Enabled = true;
                    MemReplace.Enabled = true;

                    if (memory != null) memory -= double.Parse(Value.Text);
                    else memory = double.Parse(Value.Text);

                    panel1.Text = memory.ToString();

                    КопироватьПамять.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Попытайтесь ввести корректные для данной операции данные и повторите попытку", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }
        }
        private void MemoryClear_Click(object sender, EventArgs e)
        {
            MemoryClear.Enabled = false;
            MemReplace.Enabled = false;
            memory = null;
            panel1.Text = string.Empty;

            КопироватьПамять.Enabled = false;
        }
        private void MemReplace_Click(object sender, EventArgs e)
        {
            Value.Text = memory.ToString();
        }
        #endregion

        #region Циферки
        private void Num1_Click(object sender, EventArgs e)
        {
            if(Value.Text == "0") Value.Text = "1";
            else Value.Text += "1";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "2";
            else Value.Text += "2";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "3";
            else Value.Text += "3";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num4_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "4";
            else Value.Text += "4";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "5";
            else Value.Text += "5";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num6_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "6";
            else Value.Text += "6";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "7";
            else Value.Text += "7";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num8_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "8";
            else Value.Text += "8";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num9_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") Value.Text = "9";
            else Value.Text += "9";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num0_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0") { }
            else Value.Text += "0";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Comma_Click(object sender, EventArgs e)
        {
            if (Value.Text.Contains(",")) Value.Text = Value.Text.Replace(",", string.Empty);
            Value.Text += ",";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        #endregion

        #region Верхняя панель
        private void КопироватьПамять_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(memory.ToString());
            Вставить.Enabled = Clipboard.GetText() != "";
        }
        private void КопироватьПоле_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Value.Text);
            Вставить.Enabled = Clipboard.GetText() != "";
        }
        private void Вставить_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(Clipboard.GetText(), out a)) Value.Text = a.ToString();
        }
        private void Инфа_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                Info form2 = new Info();
                form2.Show();
            }
            else
            {
                Application.OpenForms["Info"].Activate();
            }
        }
        #endregion

        #region Инструменты
        private void Clear_Click(object sender, EventArgs e)
        {
            Value.Clear();
            Value.Text = "0";
        }
        private void ClearAll_Click(object sender, EventArgs e)//reset all
        {
            Value.Clear();
            Value.Text = "0";
            CurrentState = State.NoState;
            operation = "";
            answer = 0;
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = Value.Text.Substring(0, Value.Text.Length - 1);
                if(Value.Text == "") Value.Text = "0";
            }
            catch (Exception) { }
        }
        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back) { }
                    else if (Value.Text.Contains(",") || Value.Text.Contains(".")) e.Handled = true;
                }
                else e.Handled = true;
            }
        }//запрет на ввод букв(только цифры и знаки)
        #endregion

        #region Калькулятор
        private void Equally_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentState == State.Divide)
                {
                    CurrentState = State.NoState;
                    double buff2 = double.Parse(Value.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "/" + double.Parse(textBox1.Text) + "=";
                    Value.Text = (double.Parse(operation) / buff2).ToString();
                }
                if (CurrentState == State.Multiplication)
                {
                    CurrentState = State.NoState;
                    double buff2 = double.Parse(Value.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "*" + double.Parse(textBox1.Text) + "=";
                    Value.Text = (double.Parse(operation) * buff2).ToString();
                }
                if (CurrentState == State.Substraction)
                {
                    CurrentState = State.NoState;
                    double buff2 = double.Parse(Value.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "-" + double.Parse(textBox1.Text) + "=";
                    Value.Text = (double.Parse(operation) - buff2).ToString();
                }
                if (CurrentState == State.Addiction)
                {
                    CurrentState = State.NoState;
                    double buff2 = double.Parse(Value.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "+" + double.Parse(textBox1.Text) + "=";
                    Value.Text = (double.Parse(operation) + buff2).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try input incorrect data");
            }
        }//=

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (CurrentState == State.NoState)
            {
                CurrentState = State.Multiplication;
                operation = Value.Text;
                Value.Text = "";
                Value.Focus();//focus on textbox1 and clear it
                Value.SelectionStart = Value.Text.Length;
            }
        }//умножение
        private void Subtraction_Click(object sender, EventArgs e)
        {
            if (CurrentState == State.NoState)
            {
                CurrentState = State.Substraction;
                operation = Value.Text;
                Value.Text = "";
                Value.Focus();//focus on textbox1 and clear it
                Value.SelectionStart = Value.Text.Length;
            }
        }//вычитание
        private void Divide_Click(object sender, EventArgs e)
        {
            if (CurrentState == State.NoState)
            {
                CurrentState = State.Divide;
                operation = Value.Text;
                Value.Text = "";
                Value.Focus();//focus on textbox1 and clear it
                Value.SelectionStart = Value.Text.Length;
            }
        }//деление
        private void Addition_Click(object sender, EventArgs e)
        {
            if (CurrentState == State.NoState)
            {
                CurrentState = State.Addiction;
                operation = Value.Text;
                Value.Text = "";
                Value.Focus();//focus on textbox1 and clear it
                Value.SelectionStart = Value.Text.Length;
            }
        }//сложение
        private void Squart_Click(object sender, EventArgs e)//извлечение квадратного корня
        {
            try
            {
                if (Value.Text.Length > 0)
                {
                    Value.Text = Math.Sqrt(double.Parse(Value.Text)).ToString();
                }

            }
            catch (Exception) { }
        }
        private void Inverse_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = (1 / answer).ToString();
                answer = 1 / answer;
            }
            catch (Exception) { }
        }//1/x
        private void Square_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = Math.Pow(answer, 2).ToString();//x^2
                answer = Math.Pow(answer, 2);
            }
            catch (Exception)
            {
                MessageBox.Show("Попытайтесь ввести корректные для\nданной операции данные и повторите", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//x^2

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = (-answer).ToString();
                answer = -answer;
            }
            catch (Exception) { }
        }

        private void Pow_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
